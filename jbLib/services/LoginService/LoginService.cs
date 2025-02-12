using jbLib.Models;
using jbLib.services.LoginService.ViewModels;
using jbLib.services.MessengerService;
using jbLib.SqlServer;

namespace jbLib.services.LoginService;

public class LoginService
{
    private readonly DatabaseLoginModel _loginModel = new();
    private readonly LoginViewModel _loginViewModel;
    public LoginService()
    {
        _loginModel.PropertyChanged += OnDbProxyChanged;
        Messenger.Subscribe<IDbProxy>(this, OnLoginResult);
        _loginViewModel = new LoginViewModel(_loginModel);
    }

    private void OnDbProxyChanged(object? sender, EventArgs e)
    {
        Messenger.Send(5);
    }

    private void OnLoginResult(object message)
    {
        if (message is IDbProxy proxy && proxy.CheckCredentials())
        {
            _loginModel.DbProxy = proxy;
        }
    }

    private void Result(string message)
    {

    }
    public void LoginInteractive()
    {
        new DialogService.DialogService().ShowDialog<LoginViewModel>(Result);
    }
}
