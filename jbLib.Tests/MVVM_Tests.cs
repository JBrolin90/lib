using jbLib.mvvm;

namespace jbLib.xUnitTests;

public class MVVM_Tests
{

    private void MockCommand(object? parameter) => LastExecutedParameter = parameter;
    private bool CanExecuteMock(object? parameter)
    {
        LastExecutedParameter = parameter;
        return true; // replace with actual test logic   
    }
    private bool CannotExecuteMock(object? parameter)
    {
        LastExecutedParameter = parameter;
        return false; // replace with actual test logic   
    }
    private object? LastExecutedParameter { get; set; }
    [Fact]
    public void Execute_StringArgumentPassed()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand);
        object? strArg = "Test parameter";
        //Act
        sut.Execute(strArg);
        //Assert
        Assert.Equal(strArg, LastExecutedParameter);
        bool result = true; // replace with actual test logic   

        //Assert
        Assert.True(result);
    }
    [Fact]
    public void Execute_IntArgumentPassed()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand);
        object? intArg = 100;

        //Act
        sut.Execute(intArg);

        //Assert
        Assert.Equal(intArg, LastExecutedParameter);
    }
    [Fact]
    public void Execute_NullArgumentPassed()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand);
        object? nullArg = null;

        //Act
        sut.Execute(nullArg);

        //Assert
        Assert.Equal(nullArg, LastExecutedParameter);
    }


    [Fact]
    public void CanExecute_True()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand, CanExecuteMock);
        object? strArg = "Test parameter";

        //Act
        bool result = sut.CanExecute(strArg);

        //Assert
        Assert.True(result);
        Assert.Equal(strArg, LastExecutedParameter);
    }
    [Fact]
    public void CanExecute_False()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand, CannotExecuteMock);
        object? strArg = "Test parameter";

        //Act
        bool result = sut.CanExecute(strArg);

        //Assert
        Assert.False(result);
        Assert.Equal(strArg, LastExecutedParameter);
    }

    [Fact]
    public void CanExecuteChanged_EventFired()
    {
        //Arrange
        var sut = new RelayCommand(MockCommand, CanExecuteMock);
        bool eventFired = false;
        sut.CanExecuteChanged += (sender, e) => eventFired = true;

        //Act
        sut.RaiseCanExecuteChanged();

        //Assert
        Assert.True(eventFired);

    }


}
