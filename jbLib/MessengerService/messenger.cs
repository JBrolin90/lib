using System.Collections.Concurrent;


namespace jbLib.MessengerService
{

    // https://www.youtube.com/watch?v=-6Td1iLBXGw&t=1203s

    public static class Messenger
    {
        // Base class for type erasure in the collection, internal detail
        private abstract class SubscriptionBase
        {
            public object Subscriber { get; }

            protected SubscriptionBase(object subscriber)
            {
                Subscriber = subscriber ?? throw new ArgumentNullException(nameof(subscriber));
            }

            // Abstract method to invoke the action, message will be cast internally
            public abstract void InvokeUntyped(object message);
        }

        // Generic subscription holding the strongly-typed action
        private class Subscription<TMessage> : SubscriptionBase
        {
            internal readonly Action<TMessage> TypedAction;

            public Subscription(object subscriber, Action<TMessage> action) : base(subscriber)
            {
                TypedAction = action ?? throw new ArgumentNullException(nameof(action));
            }

            public void InvokeTyped(TMessage message)
            {
                TypedAction(message);
            }

            public override void InvokeUntyped(object message)
            {
                // This cast is safe because this method is only called
                // when we know 'message' is of type TMessage (e.g., from _currentState)
                InvokeTyped((TMessage)message);
            }
        }

        private static readonly ConcurrentDictionary<Type, SynchronizedCollection<SubscriptionBase>> _subscriptions = new();
        private static readonly ConcurrentDictionary<Type, object> _currentState = new();

        /// <summary>
        /// Sends a message to all subscribed listeners for the TMessage type.
        /// Also stores this message as the last known state for this message type.
        /// </summary>
        public static void Send<TMessage>(TMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            Type messageType = typeof(TMessage);
            _currentState.AddOrUpdate(messageType, message, (_, _) => message);

            if (_subscriptions.TryGetValue(messageType, out var subscribersForType))
            {
                List<SubscriptionBase> currentSubscribersSnapshot;
                lock (subscribersForType.SyncRoot) // Lock to get a consistent snapshot
                {
                    currentSubscribersSnapshot = subscribersForType.ToList();
                }

                foreach (var subscriptionBase in currentSubscribersSnapshot)
                {
                    // This cast is safe because Subscribe<TMessage> ensures
                    // only Subscription<TMessage> is stored for typeof(TMessage).
                    var typedSubscription = (Subscription<TMessage>)subscriptionBase;
                    try
                    {
                        typedSubscription.InvokeTyped(message);
                    }
                    catch (Exception ex)
                    {
                        // Consider logging the exception or a more robust error handling strategy
                        Console.Error.WriteLine($"Error invoking subscriber {typedSubscription.Subscriber} for message {messageType.Name}: {ex.Message}");
                    }
                }
            }
        }

        /// <summary>
        /// Subscribes a listener to a specific message type.
        /// The provided action will be invoked with a strongly-typed message.
        /// If a message of this type was previously sent, the action is immediately invoked with the last known state.
        /// </summary>
        public static void Subscribe<TMessage>(object subscriber, Action<TMessage> action)
        {
            if (subscriber == null)
                throw new ArgumentNullException(nameof(subscriber));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            Type messageType = typeof(TMessage);
            var subscribersForType = _subscriptions.GetOrAdd(messageType, _ => new SynchronizedCollection<SubscriptionBase>());

            var newSubscription = new Subscription<TMessage>(subscriber, action);

            lock (subscribersForType.SyncRoot)
            {
                // Optional: Prevent adding the exact same subscriber/action pair multiple times
                // This check relies on 'action' being the same delegate instance if you want to prevent duplicates of anonymous methods.
                if (subscribersForType.OfType<Subscription<TMessage>>().Any(s => s.Subscriber == subscriber && s.TypedAction == action))
                {
                    return; // Already subscribed
                }
                subscribersForType.Add(newSubscription);
            }

            // If there's a current state for this message type, invoke the new subscriber immediately.
            if (_currentState.TryGetValue(messageType, out object? ScurrentMessage))
            {
                if (ScurrentMessage is not null)
                {
                    // The cast (TMessage)ScurrentMessage is safe because _currentState
                    // is populated by Send<TMessage> with a message of type TMessage.
                    newSubscription.InvokeTyped((TMessage)ScurrentMessage);
                }
            }
        }

        /// <summary>
        /// Unsubscribes a subscriber from all messages of a specific type.
        /// </summary>
        public static void UnSubscribe<TMessage>(object subscriber)
        {
            if (subscriber == null)
                throw new ArgumentNullException(nameof(subscriber));

            Type messageType = typeof(TMessage);
            if (_subscriptions.TryGetValue(messageType, out var subscribersForType))
            {
                lock (subscribersForType.SyncRoot)
                {
                    // Iterate backwards to safely remove items
                    for (int i = subscribersForType.Count - 1; i >= 0; i--)
                    {
                        if (subscribersForType[i].Subscriber == subscriber)
                        {
                            // We know this collection is for TMessage, so all items are Subscription<TMessage>
                            subscribersForType.RemoveAt(i);
                        }
                    }

                    if (subscribersForType.Count == 0)
                    {
                        _subscriptions.TryRemove(messageType, out _);
                    }
                }
            }
        }

        /// <summary>
        /// Unsubscribes a specific action for a subscriber from a message type.
        /// Note: For this to work reliably with anonymous methods (lambdas),
        /// the 'actionToUnsubscribe' must be the exact same delegate instance that was used for subscription.
        /// </summary>
        public static void UnSubscribe<TMessage>(object subscriber, Action<TMessage> actionToUnsubscribe)
        {
            if (subscriber == null) throw new ArgumentNullException(nameof(subscriber));
            if (actionToUnsubscribe == null) throw new ArgumentNullException(nameof(actionToUnsubscribe));

            Type messageType = typeof(TMessage);
            if (_subscriptions.TryGetValue(messageType, out var subscribersForType))
            {
                lock (subscribersForType.SyncRoot)
                {
                    for (int i = subscribersForType.Count - 1; i >= 0; i--)
                    {
                        if (subscribersForType[i] is Subscription<TMessage> typedSub &&
                            typedSub.Subscriber == subscriber &&
                            typedSub.TypedAction == actionToUnsubscribe) // Reference equality for delegates
                        {
                            subscribersForType.RemoveAt(i);
                            break; // Assuming subscriber/action pair is unique
                        }
                    }

                    if (subscribersForType.Count == 0)
                    {
                        _subscriptions.TryRemove(messageType, out _);
                    }
                }
            }
        }
    }

    /*
Key improvements and how it works:

Strongly-Typed Subscription:

The Subscribe<TMessage>(object subscriber, Action<TMessage> action) method now takes an Action<TMessage>.
Internally, we use a generic Subscription<TMessage> class that stores this Action<TMessage> (as TypedAction).
Type-Safe Invocation:

When Send<TMessage>(message) is called, it retrieves the list of subscribers for typeof(TMessage).
Each SubscriptionBase object from this list is safely cast to Subscription<TMessage>. This is safe because the Subscribe method ensures only correctly typed subscriptions are stored for each message type.
We then call InvokeTyped(message) on the Subscription<TMessage> instance, which directly executes your strongly-typed Action<TMessage> with the TMessage argument, no cast needed in your handler.
Internal Casts:

The necessary type management (like casting the object from _currentState back to TMessage before invoking a new subscriber) is handled inside the EnhancedMessenger. These internal casts are safe due to the design.
Subscriber Experience:

Your subscribing code becomes cleaner:
csharp
// Example usage:
// Assuming MyMessage is a class or struct
// EnhancedMessenger.Subscribe<MyMessage>(this, (MyMessage msg) =>
// {
//     Console.WriteLine($"Received: {msg.SomeProperty}"); // msg is already MyMessage
// });
Thread Safety:

It continues to use ConcurrentDictionary and SynchronizedCollection (with appropriate locking on SyncRoot) to manage subscriptions and state in a thread-safe manner.
When dispatching messages in Send, it iterates over a snapshot (ToList()) of the subscribers to avoid issues if the collection is modified concurrently and to prevent holding locks during potentially long-running subscriber actions.    */
}