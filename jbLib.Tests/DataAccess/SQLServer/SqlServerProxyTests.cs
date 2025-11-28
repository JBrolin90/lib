using System.Data;
using System.Data.Common;
using jbLib.DataAccess.SqlServer;
using Microsoft.Data.SqlClient;
using Xunit;

namespace jbLib.Tests.DataAccess.SQLServer
{
    public class SqlServerProxyTests
    {
        [Fact]
        public void Constructor_WithConnectionString_InitializesProperties()
        {
            // Arrange
            string connectionString = "Server=dummy;Database=dummy;User Id=sa;Password=password;TrustServerCertificate=True;";

            // Act
            var proxy = new SqlServerProxy(connectionString);

            // Assert
            Assert.NotNull(proxy.Connection);
            Assert.IsType<SqlConnection>(proxy.Connection);
            Assert.Equal(connectionString, proxy.Connection.ConnectionString);
            
            Assert.NotNull(proxy.Command);
            Assert.IsType<SqlCommand>(proxy.Command);
            
            Assert.NotNull(proxy.Adapter);
            Assert.NotNull(proxy.CommandBuilder);
        }

        [Fact]
        public void CheckCredentials_WithInvalidConnectionString_ReturnsFalse()
        {
            // Arrange
            // Set a short timeout to make the test run faster
            string connectionString = "Server=doesnotexist;Database=dummy;User Id=sa;Password=password;Connection Timeout=1;TrustServerCertificate=True;";
            var proxy = new SqlServerProxy(connectionString);

            // Act
            bool result = proxy.CheckCredentials();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void BaseTablesCommand_ReturnsCommandWithCorrectQuery()
        {
            // Arrange
            string connectionString = "Server=dummy;Database=dummy;User Id=sa;Password=password;TrustServerCertificate=True;";
            var proxy = new SqlServerProxy(connectionString);

            // Act
            var command = proxy.BaseTablesCommand();

            // Assert
            Assert.NotNull(command);
            Assert.IsType<SqlCommand>(command);
            Assert.Equal(proxy.Connection, command.Connection);
            Assert.Equal("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", command.CommandText);
        }
    }
}