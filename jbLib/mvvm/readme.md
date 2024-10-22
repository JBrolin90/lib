# jbLib

`jbLib` is a .NET library that provides MVVM utilities, including `RelayCommand` and `ObservableObject`, to simplify the implementation of the MVVM pattern in WPF applications.

## Features

- **RelayCommand**: A command implementation that relays its functionality to other objects by invoking delegates.
- **ObservableObject**: A base class that implements `INotifyPropertyChanged` and `INotifyPropertyChanging` to simplify property change notifications.

## Installation

To install `jbLib`, add the project to your solution and reference it in your projects.

## Usage

### RelayCommand

The `RelayCommand` class is used to create commands that can be bound to UI elements in WPF.

```csharp
using jbLib.mvvm;
using System;

public class MyViewModel
{
    public RelayCommand MyCommand { get; }

    public MyViewModel()
    {
        MyCommand = new RelayCommand(ExecuteAction, CanExecuteAction);
    }

    private void ExecuteAction()
    {
        // Action to execute
    }

    private bool CanExecuteAction()
    {
        // Condition to determine if the action can be executed
        return true;
    }
}


using jbLib.mvvm;
using Xunit;

namespace [jbLib.Tests]
{
    public class RelayCommandTests
    {
        [Fact]
        public void Execute_ShouldInvokeAction()
        {
            // Arrange
            bool actionInvoked = false;
            Action action = () => actionInvoked = true;
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
            var command = new RelayCommand(() => { });

            // Act
            bool canExecute = command.CanExecute(null);

            // Assert
            Assert.True(canExecute);
        }

        [Fact]
        public void RaiseCanExecuteChanged_ShouldRaiseCanExecuteChangedEvent()
        {
            // Arrange
            var command = new RelayCommand(() => { });
            bool eventRaised = false;
            command.CanExecuteChanged += (sender, args) => eventRaised = true;

            // Act
            command.RaiseCanExecuteChanged();

            // Assert
            Assert.True(eventRaised);
        }
    }
}


Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

License
This project is licensed under the MIT License.