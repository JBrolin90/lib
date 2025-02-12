using Avalonia.Controls;
using jbLib.LoginService.ViewModels;

namespace jbLib.LoginService.Views;

public partial class LoginControl : UserControl
{
    public LoginControl()
    {
        DataContext=new LoginViewModel();   
        InitializeComponent();
    }
}