using Xunit;
using jbLib.PostgreSQL; // Assuming PostgresProxy is in this namespace
using jbLib.DataAccess.Common; // For IDbProxy and potentially other common interfaces/classes
using Npgsql; // For Npgsql-specific types if needed in tests
using System.Data.Common; // For DbConnection, DbCommand
using System; // For ArgumentNullException

namespace jbLib.Tests.DataAccess.PostgreSQL
{
    public class PostgresProxyTests
    {
        // A valid connection string for testing purposes.
        // Consider using a local test database or a configuration file for this.
        private const string TestConnectionString = "Host=lmde6;Port=5432;Database=postgres;Username=postgres;Password=postgres";

        // A deliberately invalid connection string for testing error handling.
        private const string InvalidTestConnectionString = "Host=invalid_host;Port=0000;Database=non_existent_db;Username=invalid_user;Password=invalid_password";

        [Fact]
        public void Constructor_WithValidConnectionString_ShouldNotThrowException()
        {
            // Arrange & Act
            var exception = Record.Exception(() => new PostgresProxy(TestConnectionString));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void Constructor_WithNullConnectionString_ShouldThrowArgumentNullException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new PostgresProxy(null!));
        }

        [Fact]
        public void Connection_Property_ShouldReturnNpgsqlConnection()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString);

            // Act
            DbConnection connection = proxy.Connection;

            // Assert
            Assert.NotNull(connection);
            Assert.IsAssignableFrom<NpgsqlConnection>(connection);
        }

        [Fact]
        public void Command_Property_ShouldReturnNpgsqlCommand()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString);

            // Act
            DbCommand command = proxy.Command;

            // Assert
            Assert.NotNull(command);
            Assert.IsAssignableFrom<NpgsqlCommand>(command);
            Assert.Same(proxy.Connection, command.Connection); // Verifies command is associated with the proxy's connection
        }

        [Fact]
        public void Adapter_Property_ShouldReturnAdapterWrapper()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString);

            // Act
            IDbDataAdapterWrapper adapter = proxy.Adapter;

            // Assert
            Assert.NotNull(adapter);
            // If DbDataAdapterWrapper has a way to get the underlying adapter:
            // Assert.IsAssignableFrom<NpgsqlDataAdapter>(adapter.GetInternalAdapter());
        }

        [Fact]
        public void CommandBuilder_Property_ShouldReturnCommandBuilderWrapper()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString);

            // Act
            ICommandBuilderWrapper commandBuilder = proxy.CommandBuilder;

            // Assert
            Assert.NotNull(commandBuilder);
            // If CommandBuilderWrapper has a way to get the underlying builder:
            // Assert.IsAssignableFrom<NpgsqlCommandBuilder>(commandBuilder.GetInternalBuilder());
        }

        // --- Tests for CheckCredentials ---
        // Note: These tests require a running PostgreSQL instance accessible with the TestConnectionString.
        // Or, you'd need to mock the NpgsqlConnection behavior.


        [Fact]
        [Trait("Category", "Integration")] // Mark as integration test if it hits a real DB
        public void CheckCredentials_WithValidCredentials_ShouldReturnTrue()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString); // Use a connection string to a real, accessible test DB

            // Act
            bool result = proxy.CheckCredentials();

            // Assert
            Assert.True(result, "CheckCredentials returned false for valid credentials.");
        }

        [Fact]
        [Trait("Category", "Integration")] // Mark as integration test
        public void CheckCredentials_WithInvalidCredentials_ShouldReturnFalse()
        {
            PostgresProxy proxy;
            bool result = false;
            try
            {
                // Arrange
                proxy = new PostgresProxy(InvalidTestConnectionString); // Use an invalid connection string

                // Act
                result = proxy.CheckCredentials();

                // Assert
                Assert.False(result, "CheckCredentials returned true for invalid credentials.");
            }
            catch (System.ArgumentException ex)
            {
                // Handle the exception if needed, or just assert that it was thrown
                Assert.NotNull(ex);
            }

            // Assert
            Assert.False(result, "CheckCredentials returned true for invalid credentials.");
        }


        [Fact]
        public void BaseTablesCommand_ShouldReturnConfiguredNpgsqlCommand()
        {
            // Arrange
            var proxy = new PostgresProxy(TestConnectionString);
            var expectedCommandText = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type = 'BASE TABLE' ORDER BY table_name";

            // Act
            DbCommand command = proxy.BaseTablesCommand();

            // Assert
            Assert.NotNull(command);
            Assert.IsAssignableFrom<NpgsqlCommand>(command);
            Assert.Equal(expectedCommandText, command.CommandText);
            Assert.Same(proxy.Connection, command.Connection); // Verifies command is associated with the proxy's connection
        }

        // Add more test methods for other public members of PostgresProxy
        // For example:
        // [Fact]
        // public void SomeOtherMethod_Scenario_ExpectedBehavior() { ... }
    }
}