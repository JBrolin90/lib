using jbLib.Models;
using jbLib.mvvm;
using jbLib.MessengerService;
using jbLib.SqlServer;

namespace jbLib.LoginService.ViewModels;

public record DbLoginSuccess(bool Success);
public class LoginViewModel : ObservableObject, IDisposable
{
    private readonly DatabaseLoginModel _databaseModel;
    private string _server = string.Empty;
    private string _database = string.Empty;
    private string _username = string.Empty;
    private string _password = string.Empty;
    private string _message = "I wish you a good login experience!";
    private RelayCommand LoginCommand { get; }

    private DialogService.DialogService _loginDialogService = new();

    public LoginViewModel()
    {
        _databaseModel = new();
        LoginCommand = new RelayCommand(Login, CanLogin);
    }

    private void CallBack(string message)
    {
        Message = message;
    }

    public LoginViewModel(DatabaseLoginModel databaseModel)
    {
        this._databaseModel = databaseModel;
        LoginCommand = new RelayCommand(Login, CanLogin);
    }

    private void OnTextChanged()
    {
        LoginCommand.RaiseCanExecuteChanged();
    }

    private bool CanLogin(object? parameter)
    {
        return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
    }

    private bool DoLogin()
    {
        CredentialsModel credentials = new()
        {
            Server = Server,
            Database = Database,
            Username = Username,
            Password = Password
        };

        var success = _databaseModel.Login(credentials);
        return success;
    }

    private async void Login(object? parameter)
    {
        Message = "Logging in...";
        var success = await Task.Run(DoLogin);
        Message = success ? "Login successful!" : "Login failed!";
        Messenger.Send(new DbLoginSuccess(success));
        if (success && _databaseModel.DbProxy != null)
            Messenger.Send<IDbProxy>(_databaseModel.DbProxy);
    }

    public void Dispose()
    {
        _loginDialogService.Dispose();
        _databaseModel.Dispose();
    }

    public string Server
    {
        get => _server;
        set
        {
            if (_server == value) return;
            OnPropertyChanging();
            _server = value;
            OnPropertyChanged();
            OnTextChanged();
        }
    }

    public string Database
    {
        get => _database;
        set
        {
            if (_database == value) return;
            OnPropertyChanging();
            _database = value;
            OnPropertyChanged();
            OnTextChanged();
        }
    }

    public string Username
    {
        get => _username;
        set
        {
            if (_username == value) return;
            OnPropertyChanging(nameof(Username));
            _username = value;
            OnPropertyChanged(nameof(Username));
            OnTextChanged();
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            if (_password == value) return;
            OnPropertyChanging(nameof(Password));
            _password = value;
            OnPropertyChanged(nameof(Password));
            OnTextChanged();
        }
    }

    public string Message
    {
        get => _message;
        set
        {
            if (_message == value) return;
            OnPropertyChanging(nameof(Message));
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }
}
