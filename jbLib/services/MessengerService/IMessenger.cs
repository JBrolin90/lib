namespace jbLib.services.MessengerService;

public interface IMessenger
{
    static abstract void Send<TMessage>(TMessage message);
    static abstract void Subscribe<TMessage>(object subscriber, Action<object> action);
    static abstract void UnSubscribe<TMessage>(object subscriber);
}
