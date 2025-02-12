using System;
using System.Windows.Input;
using jbLib.mvvm;
using Xunit;

namespace jbLib.Tests
{
    public class RelayCommandTests
    {
        [Fact]
        public void Execute_ShouldInvokeAction()
        {
            // Arrange
            bool actionInvoked = false;
            Action<object?> action = (obj) => actionInvoked = true;
            var command = new RelayCommand(action);

            // Act
            command.Execute(null);

            // Assert
            Assert.True(actionInvoked);
        }

        [Fact]
        public void CanExecute_ShouldReturnTrue_WhenCanExecuteIsNull()
        {
            // Arrange
            var command = new RelayCommand((obj) => { });

            // Act
            bool canExecute = command.CanExecute(null);

            // Assert
            Assert.True(canExecute);
        }

        [Fact]
        public void CanExecute_ShouldReturnFalse_WhenCanExecuteReturnsFalse()
        {
            // Arrange
            var command = new RelayCommand((obj) => { }, (obj) => false);

            // Act
            bool canExecute = command.CanExecute(null);

            // Assert
            Assert.False(canExecute);
        }

        [Fact]
        public void CanExecute_ShouldReturnTrue_WhenCanExecuteReturnsTrue()
        {
            // Arrange
            var command = new RelayCommand((obj) => { }, (obj) => true);

            // Act
            bool canExecute = command.CanExecute(null);

            // Assert
            Assert.True(canExecute);
        }

        [Fact]
        public void RaiseCanExecuteChanged_ShouldRaiseCanExecuteChangedEvent()
        {
            // Arrange
            var command = new RelayCommand((obj) => { });
            bool eventRaised = false;
            command.CanExecuteChanged += (sender, args) => eventRaised = true;

            // Act
            command.RaiseCanExecuteChanged();

            // Assert
            Assert.True(eventRaised);
        }
    }
}