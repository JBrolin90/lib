using Avalonia.Controls;
using jbLib.LoginService.ViewModels;

namespace jbLib.LoginService.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        DataContext = new LoginViewModel();
        InitializeComponent();
    }
    public LoginWindow(LoginViewModel viewModel)
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}