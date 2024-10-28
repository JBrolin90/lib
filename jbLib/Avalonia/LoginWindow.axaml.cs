using Avalonia.Controls;
using jbLib.ViewModels;

namespace jbLib.Login;

public partial class LoginWindow : Window
{
    LoginViewModel viewModel;
    public LoginWindow()
    {
        viewModel = new();
        DataContext = viewModel;
        InitializeComponent();
    }
    public LoginWindow(LoginViewModel viewModel)
    {
        this.viewModel = viewModel;
        DataContext = viewModel;
        InitializeComponent();
    }
}