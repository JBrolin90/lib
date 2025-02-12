using System;
//using System.Data;
using System.Data.Common;
using jbLib.SqlServer;
using Moq;
using Xunit;

namespace jbLib.Tests
{
    public class DbTableCrudTests
    {
        private readonly string _tableName = "TestTable";
        private readonly DbTableCrud _dbTableCrud;
        private readonly Mock<IDbProxy> _mockDbProxy;
        private readonly Mock<DbConnection> _mockConnection;
        private readonly Mock<DbCommand> _mockCommand;
        private readonly Mock<ICommandBuilderWrapper> _mockCommandBuilder;
        private readonly Mock<IDbDataAdapterWrapper> _mockAdapter;
        private readonly System.Data.DataSet _dataSet;

        public DbTableCrudTests()
        {
            _mockDbProxy = new Mock<IDbProxy>();
            _mockConnection = new Mock<DbConnection>();
            _mockCommand = new Mock<DbCommand>();
            _mockAdapter = new Mock<IDbDataAdapterWrapper>();
            _mockCommandBuilder = new Mock<ICommandBuilderWrapper>();
            _dataSet = new System.Data.DataSet();

            _mockDbProxy.Setup(p => p.Connection).Returns(_mockConnection.Object);
            _mockDbProxy.Setup(p => p.Command).Returns(_mockCommand.Object);
            _mockDbProxy.Setup(p => p.Adapter).Returns(_mockAdapter.Object);
            _mockDbProxy.Setup(p => p.CommandBuilder).Returns(_mockCommandBuilder.Object);

            _dbTableCrud = new DbTableCrud(_mockDbProxy.Object, _dataSet, _tableName);
        }

        [Fact]
        public void Read_ShouldFillDataSet()
        {
            // Arrange
            var setup = _mockAdapter.Setup(a => a.Fill(It.IsAny<System.Data.DataSet>(), _tableName));
            var callback = setup.Callback<System.Data.DataSet, string>((ds, tableName) => ds.Tables.Add(new System.Data.DataTable(tableName)));
            var ret = callback.Returns(1);

            // Act
            var result = _dbTableCrud.Read();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(_tableName, result.TableName);
        }

        [Fact]
        public void CreateUpdateDelete_ShouldCallUpdate()
        {
            // Arrange
            var dataTable = new System.Data.DataTable(_tableName);
            _dataSet.Tables.Add(dataTable);

            _mockCommandBuilder.Setup(cb => cb.GetUpdateCommand()).Returns(_mockCommand.Object);
            _mockCommandBuilder.Setup(cb => cb.GetDeleteCommand()).Returns(_mockCommand.Object);
            _mockCommandBuilder.Setup(cb => cb.GetInsertCommand()).Returns(_mockCommand.Object);

            // Act
            _dbTableCrud.CreateUpdateDelete();

            // Assert
            _mockAdapter.Verify(a => a.Update(It.IsAny<System.Data.DataSet>(), _tableName), Times.Once);
        }
    }

}