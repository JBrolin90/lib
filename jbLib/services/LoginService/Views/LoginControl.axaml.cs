using Avalonia.Controls;
using jbLib.services.LoginService.ViewModels;

namespace jbLib.services.LoginService.Views;

public partial class LoginControl : UserControl
{
    public LoginControl()
    {
        DataContext=new LoginViewModel();   
        InitializeComponent();
    }
}