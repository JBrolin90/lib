using System.Threading.Tasks;
using jbLib.mvvm;
using Login.Models;

namespace Login.ViewModels;

public class LoginViewModel : ObservableObject
{
    private DatabaseModel databaseModel = new();
    private string _server = string.Empty;
    private string _database = string.Empty;
    private string _username = string.Empty;
    private string _password = string.Empty;
    private string _message = "I wish you a good login experience!";
    public RelayCommand LoginCommand { get; }

    public LoginViewModel()
    {
        LoginCommand = new RelayCommand(Login, CanLogin);
    }

    public void OnTextChanged()
    {
        LoginCommand.RaiseCanExecuteChanged();
    }

    public bool CanLogin(object? parameter)
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

        bool success = databaseModel.Login(credentials);
        return success;
    }
    public async void Login(object? parameter)
    {
        bool success = false;
        Message = "Logging in...";
        success = await Task.Run(DoLogin);
        Message = success ? "Login successful!" : "Login failed!";
    }

    public string Server
    {
        get => _server;
        set
        {
            if (_server != value)
            {
                OnPropertyChanging();
                _server = value;
                OnPropertyChanged();
                OnTextChanged();
            }
        }
    }
    public string Database
    {
        get => _database;
        set
        {
            if (_database != value)
            {
                OnPropertyChanging();
                _database = value;
                OnPropertyChanged();
                OnTextChanged();
            }
        }
    }
    public string Username
    {
        get => _username;
        set
        {
            if (_username != value)
            {
                OnPropertyChanging(nameof(Username));
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnTextChanged();
            }
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            if (_password != value)
            {
                OnPropertyChanging(nameof(Password));
                _password = value;
                OnPropertyChanged(nameof(Password));
                OnTextChanged();
            }
        }
    }
    public string Message
    {
        get => _message;
        set
        {
            if (_message != value)
            {
                OnPropertyChanging(nameof(Message));
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }
    }



}
