using jbLib.mvvm;
using jbLib.SqlServer;

namespace jbLib.Models;

public class CredentialsModel
{
    public string Server { get; set; } = "localhost";
    public string Database { get; set; } = "master";
    public string Username { get; set; } = "sa";
    public string Password { get; set; } = "P@ssw0rd!";
}

public class DatabaseLoginModel : ObservableObject, IDisposable
{
    private CredentialsModel? _credentials;
    public IDbProxy? _dbProxy = null;
    public IDbProxy? DbProxy
    {
        get => _dbProxy;
        set
        {
            OnPropertyChanging();
            _dbProxy = value;
            OnPropertyChanged();
        }
    }

    public DatabaseLoginModel()
    {
    }

    public bool Login(CredentialsModel credentials)
    {
        _credentials = credentials;
        string connectionString = $"Data Source={credentials.Server}; ";
        connectionString += $"User ID={credentials.Username}; ";
        connectionString += $"Password={credentials.Password}; ";
        connectionString += $"Database={credentials.Database}; ";
        connectionString += $"Connect Timeout=30;Encrypt=True; ";
        connectionString += $"Trust Server Certificate=True; ";
        connectionString += $"Application Intent=ReadWrite; ";
        connectionString += $"Multi Subnet Failover=False ";
        Console.WriteLine(connectionString);

        DbProxy = new SqlServerProxy(connectionString);
        return DbProxy.CheckCredentials();
    }

    public void Dispose()
    {

    }
}


