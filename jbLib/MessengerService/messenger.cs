using System.Collections.Concurrent;

namespace jbLib.MessengerService
{

    public interface ISubscription<TMessage>
    {
        object Subscriber { get; }
        Action<TMessage> Action { get; }
    }
    // https://www.youtube.com/watch?v=-6Td1iLBXGw&t=1203s
    public class Messenger : IMessenger
    {
        private static readonly ConcurrentDictionary<Type, SynchronizedCollection<Subscription>> _subscriptions = new();
        private static readonly ConcurrentDictionary<Type, object> _currentState = new();
        public static void Send<TMessage>(TMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            if (!_subscriptions.ContainsKey(typeof(TMessage)))
                _subscriptions.TryAdd(typeof(TMessage), new SynchronizedCollection<Subscription>());

            _currentState.AddOrUpdate(typeof(TMessage), ((_) => message), (_, _) => message);
            foreach (var subscription in _subscriptions[typeof(TMessage)])
                subscription.Action(message);
        }
        public static void Subscribe<TMessage>(object subscriber, Action<object> action)
        {
            if (!_subscriptions.ContainsKey(typeof(TMessage)))
                _subscriptions.TryAdd(typeof(TMessage), new SynchronizedCollection<Subscription>());

            var newSubscriber = new Subscription(subscriber, action);

            _subscriptions[typeof(TMessage)].Add(newSubscriber);
            if (_currentState.ContainsKey(typeof(TMessage)))
                newSubscriber.Action(_currentState[typeof(TMessage)]);

        }
        public static void UnSubscribe<TMessage>(object subscriber)
        {
            if (!_subscriptions.ContainsKey(typeof(TMessage)))
                return;
            var subscription = _subscriptions[typeof(TMessage)].FirstOrDefault(x => x.Subscriber == subscriber);
            if (subscription != null)
                _subscriptions[typeof(TMessage)].Remove(subscription);
        }

        private record Subscription(object Subscriber, Action<object> Action);
    }
}