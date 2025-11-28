# DataAccess Layer

The `jbLib.DataAccess` layer provides a unified abstraction over different ADO.NET database providers (SQLite, SQL Server, PostgreSQL, etc.). It allows the application to interact with various databases using a consistent interface, decoupling the business logic from specific database implementation details.

## Architecture

The core of the system is the **Proxy Pattern**. Instead of using `SqlConnection` or `SqliteConnection` directly, the application uses the `IDbProxy` interface.

### Key Interfaces

#### 1. `IDbProxy`
The main entry point for database interactions. It exposes the underlying connection, command objects, and adapters in a generic way.

*   **`Connection`**: The underlying `DbConnection`.
*   **`Command`**: A `DbCommand` associated with the connection.
*   **`Adapter`**: An abstraction (`IDbDataAdapterWrapper`) for filling DataSets and updating changes.
*   **`CommandBuilder`**: An abstraction (`ICommandBuilderWrapper`) for automatically generating Insert/Update/Delete commands.
*   **`CheckCredentials()`**: A method to validate the connection string.
*   **`BaseTablesCommand()`**: Returns a command to list all user tables in the database.

#### 2. `IDbDataAdapterWrapper`
Wraps the standard `DbDataAdapter`. This is necessary because not all ADO.NET providers implement `DbDataAdapter` in the same way (or at all, in lightweight implementations).
*   **`Fill(DataSet, srcTable)`**: Populates a DataSet.
*   **`Update(DataSet, srcTable)`**: Persists changes back to the database.

#### 3. `ICommandBuilderWrapper`
Wraps the `DbCommandBuilder`. It generates SQL statements for updates based on the `SelectCommand`.

---

## Existing Implementations

The library currently supports:
*   **SQLite**: `jbLib.DataAccess.SQLite.SqliteProxy`
*   **SQL Server**: `jbLib.DataAccess.SqlServer.SqlServerProxy`
*   **PostgreSQL**: `jbLib.DataAccess.PostgreSQL.PostgresProxy`

---

## How to Add Support for a New Database

To add support for a new database (e.g., MySQL, Oracle), follow these steps:

### Step 1: Install Dependencies
Add the NuGet package for the database provider to the `jbLib` project.
*   Example: `MySql.Data` or `MySqlConnector`.

### Step 2: Create Directory
Create a new folder in `jbLib/DataAccess/` for the new provider (e.g., `MySQL`).

### Step 3: Implement `IDbProxy`
Create a class that implements `IDbProxy`.

```csharp
using System.Data.Common;
using jbLib.DataAccess.Common;
// Add provider namespace, e.g., MySql.Data.MySqlClient

namespace jbLib.DataAccess.MySQL
{
    public class MySqlProxy : IDbProxy
    {
        private readonly MySqlConnection _connection;
        private readonly MySqlCommand _command;
        private readonly IDbDataAdapterWrapper _adapterWrapper;
        private readonly ICommandBuilderWrapper _commandBuilderWrapper;

        public DbConnection Connection => _connection;
        public DbCommand Command => _command;
        public IDbDataAdapterWrapper Adapter => _adapterWrapper;
        public ICommandBuilderWrapper CommandBuilder => _commandBuilderWrapper;

        public MySqlProxy(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _command = new MySqlCommand { Connection = _connection };

            // 1. Create the provider-specific adapter
            var adapter = new MySqlDataAdapter(); 
            
            // 2. Wrap it using the generic DbDataAdapterWrapper
            _adapterWrapper = new DbDataAdapterWrapper(adapter);

            // 3. Create and wrap the CommandBuilder
            var builder = new MySqlCommandBuilder(adapter);
            _commandBuilderWrapper = new CommandBuilderWrapper(builder);
        }

        public bool CheckCredentials()
        {
            try
            {
                _connection.Open();
                _connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DbCommand BaseTablesCommand()
        {
            // Return a command that lists all tables for the specific SQL dialect
            return new MySqlCommand("SHOW TABLES;", _connection);
        }
    }
}
```

### Step 4: Handle Adapter & CommandBuilder
Most standard ADO.NET providers (MySQL, Oracle) inherit from `DbDataAdapter` and `DbCommandBuilder`.
*   **Standard Providers**: You can simply use the existing `DbDataAdapterWrapper` and `CommandBuilderWrapper` classes found in `jbLib.DataAccess.Common` as shown in the example above.
*   **Non-Standard Providers**: If the provider does *not* inherit from `DbDataAdapter` (like `Microsoft.Data.Sqlite` in some configurations), you must implement your own `IDbDataAdapterWrapper` and `ICommandBuilderWrapper` specific to that provider. See `jbLib.DataAccess.SQLite.SqliteDataAdapterWrapper` for an example.

### Step 5: Register/Use
You can now instantiate your new proxy wherever `IDbProxy` is required.

```csharp
IDbProxy myProxy = new MySqlProxy("Server=myServer;Database=myData;Uid=user;Pwd=password;");
```
