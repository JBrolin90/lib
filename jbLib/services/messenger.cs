using System.Collections.Concurrent;

namespace jbLib.Services
{
    // https://www.youtube.com/watch?v=-6Td1iLBXGw&t=1203s
    public class Messenger : IMessenger
    {
        ConcurrentDictionary<Type, SynchronizedCollection<Subscription>> _Subscriptions = new();
        ConcurrentDictionary<Type, object> _CurrentState = new();
        public void Send<TMessage>(TMessage message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            if (!_Subscriptions.ContainsKey(typeof(TMessage)))
                _Subscriptions.TryAdd(typeof(TMessage), new SynchronizedCollection<Subscription>());

            _CurrentState.AddOrUpdate(typeof(TMessage), ((o) => message), (o, old) => message);
            foreach (var subscription in _Subscriptions[typeof(TMessage)])
                subscription.Action(message);
        }
        public void Subscribe<TMessage>(object subscriber, Action<object> action)
        {
            if (!_Subscriptions.ContainsKey(typeof(TMessage)))
                _Subscriptions.TryAdd(typeof(TMessage), new SynchronizedCollection<Subscription>());

            var newSubscriber = new Subscription(subscriber, action);

            _Subscriptions[typeof(TMessage)].Add(newSubscriber);
            if (_CurrentState.ContainsKey(typeof(TMessage)))
                newSubscriber.Action(_CurrentState[typeof(TMessage)]);

        }
        public void UnSubscribe<TMessage>(object subscriber)
        {
            if (!_Subscriptions.ContainsKey(typeof(TMessage)))
                return;
            var subscription = _Subscriptions[typeof(TMessage)].FirstOrDefault(x => x.Subscriber == subscriber);
            if (subscription != null)
                _Subscriptions[typeof(TMessage)].Remove(subscription);
        }
        public record Subscription(object Subscriber, Action<object> Action);
    }
}