using jbLib.Services;
using jbLib.services.MessengerService;
using Moq;

namespace jbLib.Tests;

public class MessengerTests
{
    private readonly Messenger _Sut = new();
    public record FakeMessage(string Message);
    public record AnotherFakeMessage(string Message);
    public interface IFakeObserver { void CallMeWithMessage(object message); }

    [Fact]
    public void Send_NotifiesSubscriber_WhenSingleSubscriber()
    {
        // Arrange
        var fakeObserver = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        _Sut.Subscribe<FakeMessage>(fakeObserver.Object, fakeObserver.Object.CallMeWithMessage);

        // Act
        _Sut.Send(message);

        // Assert
        fakeObserver.Verify(x => x.CallMeWithMessage(message), Times.Once);
    }

    [Fact]
    public void Send_DoesNotNotifySubscriber_WhenSubscriberUnsubscribes()
    {
        // Arrange
        var fakeObserver = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        _Sut.Subscribe<FakeMessage>(fakeObserver.Object, fakeObserver.Object.CallMeWithMessage);


        // Act
        _Sut.UnSubscribe<FakeMessage>(fakeObserver.Object);
        _Sut.Send(message);

        // Assert
        fakeObserver.Verify(x => x.CallMeWithMessage(message), Times.Never);
    }

    [Fact]
    public void Send_NotifiesAllSubscribers_WhenMoreThanOneSubscriber()
    {
        // Arrange
        var fakeObserver1 = new Mock<IFakeObserver>();
        var fakeObserver2 = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        _Sut.Subscribe<FakeMessage>(fakeObserver1.Object, fakeObserver1.Object.CallMeWithMessage);
        _Sut.Subscribe<FakeMessage>(fakeObserver2.Object, fakeObserver2.Object.CallMeWithMessage);

        // Act
        _Sut.Send(message);

        // Assert
        fakeObserver1.Verify(x => x.CallMeWithMessage(message), Times.Once);
        fakeObserver2.Verify(x => x.CallMeWithMessage(message), Times.Once);
    }
    [Fact]
    public void Send_NotifiesOnlySubscribersOfSpecifiedType_WhenMoreThanOneSubscriberAndTypeUsed()
    {
        // Arrange
        var fakeObserver1 = new Mock<IFakeObserver>();
        var fakeObserver2 = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        var message2 = new AnotherFakeMessage(string.Empty);
        _Sut.Subscribe<FakeMessage>(fakeObserver1.Object, fakeObserver1.Object.CallMeWithMessage);
        _Sut.Subscribe<AnotherFakeMessage>(fakeObserver2.Object, fakeObserver2.Object.CallMeWithMessage);

        // Act
        _Sut.Send(message);

        // Assert
        fakeObserver1.Verify(x => x.CallMeWithMessage(message), Times.Once);
        fakeObserver2.Verify(x => x.CallMeWithMessage(It.IsAny<object>()), Times.Never);
    }

    [Fact]
    public void Send_ThrowsException_WhenMessageIsNull()
    {
        // Arrange
        string? message = null;

        // Act
        Action act = () => _Sut.Send(message);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }

    [Fact]
    public void Send_DoesNotThrow_WhenNoSubscribersForMessageTypeExists()
    {
        // Arrange
        var message = new FakeMessage(string.Empty);

        // Act
        Action act = () => _Sut.Send(message);

        // Assert
        act();
    }

    [Fact]
    public void UnSubscribe_DoesNotThrow_WhenNotSubscriptionsForTheMessageTypeExists()
    {
        // Arrange
        var fakeObserver = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        _Sut.Subscribe<AnotherFakeMessage>(fakeObserver.Object, fakeObserver.Object.CallMeWithMessage);

        // Act
        Action act = () => _Sut.UnSubscribe<FakeMessage>(fakeObserver.Object);

        // Assert
        act();
    }

    [Fact]
    public void Subscribe_CausesActionToBeCalled_WhenSendHappensBeforeSubscription()
    {
        // Arrange
        var fakeObserver = new Mock<IFakeObserver>();
        var message = new FakeMessage(string.Empty);
        _Sut.Send(message);

        // Act
        _Sut.Subscribe<FakeMessage>(fakeObserver.Object, fakeObserver.Object.CallMeWithMessage);

        // Assert
        fakeObserver.Verify(x => x.CallMeWithMessage(message), Times.Once);
    }
}
