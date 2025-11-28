using System.Data;
using jbLib.DataAccess.SQLite;
using Microsoft.Data.Sqlite;
using Xunit;

namespace jbLib.Tests.DataAccess.SQLite
{
    public class SqliteProxyTests
    {
        [Fact]
        public void Constructor_WithValidConnectionString_InitializesProperties()
        {
            // Arrange
            string connectionString = "Data Source=:memory:";

            // Act
            var proxy = new SqliteProxy(connectionString);

            // Assert
            Assert.NotNull(proxy.Connection);
            Assert.IsType<SqliteConnection>(proxy.Connection);
            Assert.NotNull(proxy.Command);
            Assert.IsType<SqliteCommand>(proxy.Command);
            Assert.NotNull(proxy.Adapter);
            Assert.NotNull(proxy.CommandBuilder);
            Assert.Equal(ConnectionState.Closed, proxy.Connection.State);
        }

        [Fact]
        public void Constructor_WithNullConnectionString_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new SqliteProxy(null!));
        }

        [Fact]
        public void CheckCredentials_WithValidConnectionString_ReturnsTrue()
        {
            // Arrange
            var proxy = new SqliteProxy("Data Source=:memory:");

            // Act
            bool result = proxy.CheckCredentials();

            // Assert
            Assert.True(result);
            // Ensure connection is closed after check
            Assert.Equal(ConnectionState.Closed, proxy.Connection.State);
        }

        [Fact]
        public void Constructor_WithInvalidConnectionString_ThrowsArgumentException()
        {
            // Arrange
            // Providing an invalid option triggers an exception in SqliteConnection constructor
            string invalidConnectionString = "Data Source=:memory:;InvalidOption=True";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new SqliteProxy(invalidConnectionString));
        }

        [Fact]
        public void BaseTablesCommand_ReturnsCommandWithCorrectQuery()
        {
            // Arrange
            var proxy = new SqliteProxy("Data Source=:memory:");
            proxy.Connection.Open();

            // Create a test table to verify the query works
            using (var setupCmd = proxy.Connection.CreateCommand())
            {
                setupCmd.CommandText = "CREATE TABLE TestTable (Id INTEGER);";
                setupCmd.ExecuteNonQuery();
            }

            // Act
            var command = proxy.BaseTablesCommand();

            // Assert
            Assert.NotNull(command);
            Assert.Equal(proxy.Connection, command.Connection);
            Assert.Contains("sqlite_master", command.CommandText);

            using var reader = command.ExecuteReader();
            Assert.True(reader.Read());
            Assert.Equal("TestTable", reader["table_name"]);
        }

        [Fact]
        public void Adapter_Fill_PopulatesDataSetFromDatabase()
        {
            // Arrange
            var proxy = new SqliteProxy("Data Source=:memory:");
            proxy.Connection.Open();

            // Seed data
            using (var cmd = proxy.Connection.CreateCommand())
            {
                cmd.CommandText = "CREATE TABLE Users (Name TEXT); INSERT INTO Users VALUES ('Alice');";
                cmd.ExecuteNonQuery();
            }

            proxy.Command.CommandText = "SELECT * FROM Users";
            var dataSet = new DataSet();

            // Act
            int count = proxy.Adapter.Fill(dataSet, "Users");

            // Assert
            Assert.Equal(1, count);
            Assert.True(dataSet.Tables.Contains("Users"));
            Assert.Equal("Alice", dataSet.Tables["Users"]!.Rows[0]["Name"]);
        }

        [Fact]
        public void Adapter_Update_CallsAcceptChanges_StubBehavior()
        {
            // Arrange
            var proxy = new SqliteProxy("Data Source=:memory:");
            proxy.Connection.Open();

            // Seed data
            using (var cmd = proxy.Connection.CreateCommand())
            {
                cmd.CommandText = "CREATE TABLE Users (Name TEXT); INSERT INTO Users VALUES ('Alice');";
                cmd.ExecuteNonQuery();
            }

            proxy.Command.CommandText = "SELECT * FROM Users";
            var dataSet = new DataSet();
            proxy.Adapter.Fill(dataSet, "Users");

            // Modify the local data
            var table = dataSet.Tables["Users"]!;
            table.Rows[0]["Name"] = "Bob";

            // Pre-assert: Row should be Modified
            Assert.Equal(DataRowState.Modified, table.Rows[0].RowState);

            // Act
            // Note: The current implementation is a stub that only calls AcceptChanges
            proxy.Adapter.Update(dataSet, "Users");

            // Assert
            // Row should be Unchanged after AcceptChanges is called
            Assert.Equal(DataRowState.Unchanged, table.Rows[0].RowState);
            Assert.Equal("Bob", table.Rows[0]["Name"]);
        }

        [Fact]
        public void CommandBuilder_GetCommands_ReturnsCommandsWithConnection()
        {
            // Arrange
            var proxy = new SqliteProxy("Data Source=:memory:");
            
            // The CommandBuilderWrapper relies on the Adapter's SelectCommand having a connection
            // The proxy constructor sets this up automatically.

            // Act
            var insertCmd = proxy.CommandBuilder.GetInsertCommand();
            var updateCmd = proxy.CommandBuilder.GetUpdateCommand();
            var deleteCmd = proxy.CommandBuilder.GetDeleteCommand();

            // Assert
            Assert.NotNull(insertCmd);
            Assert.Equal(proxy.Connection, insertCmd.Connection);
            
            Assert.NotNull(updateCmd);
            Assert.Equal(proxy.Connection, updateCmd.Connection);
            
            Assert.NotNull(deleteCmd);
            Assert.Equal(proxy.Connection, deleteCmd.Connection);
        }
    }
}