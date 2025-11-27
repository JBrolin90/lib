using System.Data;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using jbLib.DataAccess.Common;

namespace jbLib.DataAccess.SQLite
{
    public class SqliteProxy : IDbProxy
    {
        private readonly string _connectionString;
        private readonly SqliteConnection _connection;
        private readonly SqliteCommand _command;
        private readonly IDbDataAdapterWrapper _adapterWrapper;
        private readonly ICommandBuilderWrapper _commandBuilderWrapper;

        // --- Interface Implementation ---

        public DbConnection Connection => _connection;

        public DbCommand Command => _command;

        public IDbDataAdapterWrapper Adapter => _adapterWrapper;

        public ICommandBuilderWrapper CommandBuilder => _commandBuilderWrapper;

        /// <summary>
        /// Initializes a new instance of the SqliteProxy class.
        /// </summary>
        /// <param name="connectionString">The connection string used to connect to the SQLite database.</param>
        public SqliteProxy(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _connection = new SqliteConnection(_connectionString);
            _command = new SqliteCommand { Connection = _connection };

            // Create a custom adapter wrapper for SQLite
            _adapterWrapper = new SqliteDataAdapterWrapper(_command);
            _commandBuilderWrapper = new SqliteCommandBuilderWrapper(_adapterWrapper);
        }

        /// <summary>
        /// Checks if the provided credentials in the connection string are valid by attempting to open and close a connection.
        /// </summary>
        /// <returns>True if the connection can be opened successfully, false otherwise.</returns>
        public bool CheckCredentials()
        {
            try
            {
                _connection.Open();
                _connection.Close();
                return true;
            }
            catch (SqliteException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        /// <summary>
        /// Creates and returns a DbCommand configured to retrieve base table names from the connected SQLite database.
        /// </summary>
        /// <returns>A DbCommand ready to be executed.</returns>
        public DbCommand BaseTablesCommand()
        {
            const string commandText = "SELECT name AS table_name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%' ORDER BY name";
            return new SqliteCommand(commandText, _connection);
        }
    }

    /// <summary>
    /// A custom adapter wrapper for SQLite since Microsoft.Data.Sqlite doesn't provide a DataAdapter.
    /// </summary>
    internal class SqliteDataAdapterWrapper : IDbDataAdapterWrapper
    {
        private DbCommand? _selectCommand;

        public SqliteDataAdapterWrapper(DbCommand? selectCommand = null)
        {
            _selectCommand = selectCommand;
        }

        public DbCommand? SelectCommand
        {
            get => _selectCommand;
            set => _selectCommand = value;
        }

        public int Fill(DataSet dataSet, string srcTable)
        {
            if (_selectCommand == null)
                throw new InvalidOperationException("SelectCommand must be set before calling Fill.");

            var connection = _selectCommand.Connection;
            bool wasOpen = connection?.State == ConnectionState.Open;

            try
            {
                if (connection != null && !wasOpen)
                    connection.Open();

                using var reader = _selectCommand.ExecuteReader();
                var dataTable = new DataTable(srcTable);
                dataTable.Load(reader);
                
                if (dataSet.Tables.Contains(srcTable))
                    dataSet.Tables.Remove(srcTable);
                    
                dataSet.Tables.Add(dataTable);
                return dataTable.Rows.Count;
            }
            finally
            {
                if (connection != null && !wasOpen && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public int Update(DataSet dataSet, string srcTable)
        {
            if (_selectCommand?.Connection == null)
                throw new InvalidOperationException("SelectCommand with a valid Connection must be set before calling Update.");

            if (!dataSet.Tables.Contains(srcTable))
                throw new ArgumentException($"Table '{srcTable}' not found in DataSet.", nameof(srcTable));

            var dataTable = dataSet.Tables[srcTable]!;
            var connection = _selectCommand.Connection;
            bool wasOpen = connection.State == ConnectionState.Open;
            int affectedRows = 0;

            try
            {
                if (!wasOpen)
                    connection.Open();

                // Note: For a full implementation, you would need to build INSERT/UPDATE/DELETE commands
                // This is a simplified version - consider using a more complete SQLite adapter library
                // for production use cases requiring full CRUD operations.
                
                dataTable.AcceptChanges();
                return affectedRows;
            }
            finally
            {
                if (!wasOpen && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }

    /// <summary>
    /// A custom command builder wrapper for SQLite.
    /// </summary>
    internal class SqliteCommandBuilderWrapper : ICommandBuilderWrapper
    {
        private readonly IDbDataAdapterWrapper _adapter;

        public SqliteCommandBuilderWrapper(IDbDataAdapterWrapper adapter)
        {
            _adapter = adapter ?? throw new ArgumentNullException(nameof(adapter));
        }

        public DbCommand GetInsertCommand()
        {
            var selectCommand = _adapter.SelectCommand as SqliteCommand;
            if (selectCommand?.Connection == null)
                throw new InvalidOperationException("SelectCommand must be set with a valid connection.");

            var command = new SqliteCommand { Connection = selectCommand.Connection };
            return command;
        }

        public DbCommand GetUpdateCommand()
        {
            var selectCommand = _adapter.SelectCommand as SqliteCommand;
            if (selectCommand?.Connection == null)
                throw new InvalidOperationException("SelectCommand must be set with a valid connection.");

            var command = new SqliteCommand { Connection = selectCommand.Connection };
            return command;
        }

        public DbCommand GetDeleteCommand()
        {
            var selectCommand = _adapter.SelectCommand as SqliteCommand;
            if (selectCommand?.Connection == null)
                throw new InvalidOperationException("SelectCommand must be set with a valid connection.");

            var command = new SqliteCommand { Connection = selectCommand.Connection };
            return command;
        }
    }
}
