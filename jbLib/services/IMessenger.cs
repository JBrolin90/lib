using System;

namespace jbLib.Services;

public interface IMessenger
{
    void Send<TMessage>(TMessage message);
    void Subscribe<TMessage>(object subscriber, Action<object> action);
    void UnSubscribe<TMessage>(object subscriber);
}
