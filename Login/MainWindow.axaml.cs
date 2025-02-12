using System.Windows.Input;
using Avalonia.Controls;
using jbLib.mvvm;
using jbLib.services.LoginService;

namespace Login;

public partial class MainWindow : Window
{
    private LoginService loginService;

    public ICommand LoginCommand { get; set; }
    public MainWindow(LoginService loginService)
    {
        this.loginService = loginService;
        DataContext = this;
        LoginCommand = new RelayCommand(DoTheStuff);
        InitializeComponent();
        //Login.Command = LoginCommand;
        Login2.Command = new RelayCommand(DoTheStuff);
    }

    public void DoTheStuff(object? parameter = null)
    {
        loginService.LoginInteractive();
    }
}
