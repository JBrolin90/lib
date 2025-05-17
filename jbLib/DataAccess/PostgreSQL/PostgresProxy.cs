using System.Data;
using Npgsql;
using System.Data.Common;
using jbLib.DataAccess.Common;

namespace jbLib.PostgreSQL
{
    public class PostgresProxy : IDbProxy
    {
        private readonly string _connectionString;
        private readonly NpgsqlConnection _connection;
        private readonly NpgsqlCommand _command;
        private readonly IDbDataAdapterWrapper _adapterWrapper; // Uses the shared interface
        private readonly ICommandBuilderWrapper _commandBuilderWrapper; // Uses the shared interface

        private string connStr = "Host=lmde6;Port=5432;Database=postgres;Username=postgres;Password=postgres";

        // --- Interface Implementation ---

        public DbConnection Connection => _connection;

        public DbCommand Command => _command;

        public IDbDataAdapterWrapper Adapter => _adapterWrapper;

        public ICommandBuilderWrapper CommandBuilder => _commandBuilderWrapper;

        /// <summary>
        /// Initializes a new instance of the PostgresProxy class.
        /// </summary>
        /// <param name="connectionString">The connection string used to connect to the PostgreSQL database.</param>
        public PostgresProxy(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _connection = new NpgsqlConnection(_connectionString);
            _command = new NpgsqlCommand { Connection = _connection }; // Associate command with connection

            // Create the underlying NpgsqlDataAdapter
            var npgsqlAdapter = new NpgsqlDataAdapter();
            npgsqlAdapter.SelectCommand = _command; // Associate command with adapter early

            // Wrap the NpgsqlDataAdapter using the shared DbDataAdapterWrapper
            // Assuming DbDataAdapterWrapper exists in jbLib.SqlServer namespace and is generic
            _adapterWrapper = new DbDataAdapterWrapper(npgsqlAdapter);

            // Create the underlying NpgsqlCommandBuilder, associating it with the adapter
            var npgsqlCommandBuilder = new NpgsqlCommandBuilder(npgsqlAdapter);

            // Wrap the NpgsqlCommandBuilder using the shared CommandBuilderWrapper
            // Using the CommandBuilderWrapper class from jbLib.SqlServer namespace
            _commandBuilderWrapper = new CommandBuilderWrapper(npgsqlCommandBuilder);

            // Note: Setting _adapterWrapper.SelectCommand = _command here might be redundant
            // if the adapter was already initialized with it, but ensures it's set.
            _adapterWrapper.SelectCommand = _command;
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
            catch (NpgsqlException ex) // Catch specific Npgsql exceptions related to connection/authentication
            {
                string errorMessage = ex.Message;
                Console.WriteLine(errorMessage);

                return false;
            }
            catch (Exception) // Catch other potential issues during open/close
            {
                // Optionally log other exceptions
                return false;
            }
            finally
            {
                // Ensure the connection is closed even if an unexpected error occurred after opening
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        /// <summary>
        /// Creates and returns a DbCommand configured to retrieve base table names from the connected PostgreSQL database.
        /// It typically queries the 'public' schema.
        /// </summary>
        /// <returns>A DbCommand ready to be executed.</returns>
        public DbCommand BaseTablesCommand()
        {
            // Standard INFORMATION_SCHEMA query, generally compatible with PostgreSQL.
            // Added filtering for 'public' schema, which is common. Adjust if other schemas are needed.
            // Using lowercase identifiers as is conventional in PostgreSQL.
            const string commandText = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE' ORDER BY table_name";
            return new NpgsqlCommand(commandText, _connection);
        }

        // --- No internal helper classes needed here ---
        // The DbDataAdapterWrapper and CommandBuilderWrapper classes are assumed to exist
        // externally (likely in the jbLib.SqlServer namespace based on the provided context)
        // and are designed to be reusable with any DbDataAdapter/DbCommandBuilder.
    }
}
