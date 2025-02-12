using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using jbLib.services.DialogService;
using jbLib.services.LoginService;
using jbLib.services.LoginService.ViewModels;
using jbLib.services.LoginService.Views;
using jbLib.services.MessengerService;

namespace Login;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private IMessenger _messenger = new Messenger();
    private DialogService _dialogService = new DialogService(null);
    private LoginService? _loginService;
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            _loginService = new LoginService(_messenger, _dialogService);
            _dialogService.RegisterDialog<LoginControl, LoginViewModel>();
            desktop.MainWindow = new MainWindow(_loginService);
        }

        base.OnFrameworkInitializationCompleted();
    }
}