using Avalonia.Controls;
using jbLib.ViewModels;

namespace jbLib.Login;

public partial class LoginWindow : Window
{
    LoginViewModel viewModel = new();
    public LoginWindow()
    {
        DataContext = viewModel;
        InitializeComponent();
    }
}