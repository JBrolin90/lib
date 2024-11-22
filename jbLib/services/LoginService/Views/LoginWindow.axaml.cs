using Avalonia.Controls;
using jbLib.services.LoginService.ViewModels;

namespace jbLib.services.LoginService.Views;

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