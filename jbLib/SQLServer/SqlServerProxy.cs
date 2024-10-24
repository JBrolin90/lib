using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace jbLib.SqlServer
{
    public class SqlServerProxy : IDbProxy
    {
        private readonly string connectionString;

        private IDbDataAdapterWrapper _adapterWrapper;
        //private IDataAdapter _adapter;
        private ICommandBuilderWrapper _commandBuilderWrapper;

        private SqlConnection _connection;

        public DbConnection Connection { get => _connection; }
        public DbCommand Command { get; }
        public IDbDataAdapterWrapper Adapter => _adapterWrapper;

        public ICommandBuilderWrapper CommandBuilder => (ICommandBuilderWrapper)_commandBuilderWrapper;

        public bool CheckCredentials()
        {
            try
            {
                Connection.Open();
                Connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public SqlServerProxy(string connectionString)
        {
            this.connectionString = connectionString;
            _connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            DbDataAdapter x_adapter = new SqlDataAdapter();
            _adapterWrapper = new DbDataAdapterWrapper(x_adapter);
            _commandBuilderWrapper = new CommandBuilderWrapper(new SqlCommandBuilder());
        }

        public DbCommand BaseTablesCommand()
        {
            return new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", _connection);
        }
    }
}
