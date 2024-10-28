using Avalonia.Controls;
using jbLib.services.DialogService;

namespace jbLib.Tests
{
    
    public class MockView : Control
    {
    }

    public class MockViewModel
    {
    }

    public class MockDialogWindow : IDialogWindow
    {
        public event EventHandler? Closed;
        public bool Result { get; set; }
        public void Show() {}
        public object? Content { get; set; }

        public void Close(bool result)
        {
            Result = result;
            Closed?.Invoke(this, EventArgs.Empty);
        }
    }


    public class DialogServiceTests
    {
        [Fact]
        public void RegisterDialog_ShouldMapViewModelToView()
        {
            // Arrange
            var dialogService = new DialogService(null);

            // Act
            dialogService.RegisterDialog<MockView, MockViewModel>();

            // Assert
            Assert.Contains(typeof(MockViewModel), dialogService.Mappings.Keys);
            Assert.Equal(typeof(MockView), dialogService.Mappings[typeof(MockViewModel)]);
        }

        [Fact]
        public void ShowDialog_ShouldShowRegisteredDialog()
        {
            // Arrange
            var dialog = new MockDialogWindow();
            var dialogService = new DialogService(dialog);
            dialogService.RegisterDialog<MockView, MockViewModel>();
            var myAction = new Action<string>(_ => { });
            //
            // Act
            dialogService.ShowDialog<MockViewModel>(myAction);

            var content = dialog.Content as MockView ??
                          throw new InvalidOperationException("Object reference not set to an instance of an object.");
            Type t = content.GetType() ??
                     throw new InvalidOperationException("Object reference not set to an instance of an object.");

            // Assert
            Assert.Equal(typeof(MockView), t);
        }

        [Fact]
        public void ShowDialog_ShouldInvokeCallbackWithTrueResult()
        {
            // Arrange
            var dialog = new MockDialogWindow();
            var dialogService = new DialogService(dialog);
            dialogService.RegisterDialog<MockView, MockViewModel>();

            string result = "";
            var myAction = new Action<string>(s => { result = s;});
            dialogService.ShowDialog<MockViewModel>(myAction);
            bool expected = true;   
            dialog.Close(expected);
            // Assert
            Assert.Equal(expected.ToString(), result);
        }
        [Fact]
        public void ShowDialog_ShouldInvokeCallbackWithFalseResult()
        {
            // Arrange
            var dialog = new MockDialogWindow();
            var dialogService = new DialogService(dialog);
            dialogService.RegisterDialog<MockView, MockViewModel>();

            string result = "";
            var myAction = new Action<string>(s => { result = s;});
            dialogService.ShowDialog<MockViewModel>(myAction);
            bool expected = false;   
            dialog.Close(expected);
            // Assert
            Assert.Equal(expected.ToString(), result);
        }
    }
}