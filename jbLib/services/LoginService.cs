using System;
using jbLib.Login;
using jbLib.Models;
using jbLib.services.MessengerService;
using jbLib.SqlServer;
using jbLib.ViewModels;

namespace jbLib.Services;

public class LoginService
{
    private DatabaseLoginModel loginModel = new();
    private LoginViewModel loginViewModel;
    private LoginWindow? loginWindow;
    private IMessenger messenger;
    public LoginService(IMessenger messenger)
    {
        this.messenger = messenger;
        loginModel.PropertyChanged += OnDbProxyChanged;
        messenger.Subscribe<IDbProxy>(this, OnLoginResult);
        loginViewModel = new(messenger, loginModel);
    }

    public void OnDbProxyChanged(object? sender, EventArgs e)
    {
        messenger.Send<int>(5);
    }

    public void OnLoginResult(object message)
    {
        IDbProxy? proxy = message as IDbProxy;
        if (proxy != null && proxy.CheckCredentials())
        {
            loginWindow?.Close();
        }
    }
    public IDbProxy? LoginInteractive()
    {
        loginWindow = new(loginViewModel);
        loginWindow.Show();
        return null;
    }
}
