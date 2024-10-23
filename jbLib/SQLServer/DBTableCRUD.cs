using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jbLib.SqlServer;

public class DbTableCrud
{
    private readonly IDbProxy _dbProxy;
    private readonly DataSet _dataSet;
    private string _tableName;

    public DbTableCrud(IDbProxy dbProxy, DataSet dataSet, string tableName)
    {
        _dbProxy = dbProxy;
        _dataSet = dataSet;
        _tableName = tableName;

        Connection = dbProxy.Connection;
        Command = dbProxy.Command;
        Command.CommandText = $"SELECT * FROM [{tableName}]";
        Command.Connection = Connection;
        Adapter = dbProxy.Adapter;
        CommandBuilder = dbProxy.CommandBuilder;
    }

    public DataTable Read()
    {
        Connection.Open();
        Adapter.SelectCommand = Command;
        var adapter = _dbProxy.Adapter;
        adapter.Fill(_dataSet, _tableName);
        Connection.Close();
        return _dataSet.Tables[_tableName] ?? throw new NullReferenceException();

        // Connection.Open();
        // Adapter.SelectCommand = command;
        // Adapter.Fill(_dataSet, _tableName);
        // Connection.Close();
        // return _dataSet.Tables[_tableName] ?? throw new NullReferenceException();
    }


    public DbConnection Connection { get; }
    public DbCommand Command { get; }
    public IDbDataAdapterWrapper Adapter { get; }
    public ICommandBuilderWrapper CommandBuilder { get; }

    public DbTableCrud(IDbProxy dbProxy, string tableName)
    {
        this._dbProxy = dbProxy;
        this.Connection = dbProxy.Connection;
        this.Command = dbProxy.Command;
        this.Command.CommandText = $"SELECT * FROM [{tableName}]";
        this.Command.Connection = this.Connection;
        this.Adapter = dbProxy.Adapter;
        this.CommandBuilder = dbProxy.CommandBuilder;
        this._tableName = tableName;
        this._dataSet = new DataSet();
    }
    public DbTableCrud(IDbProxy dbProxy, DbCommand command, string tableName)
    {
        this._dbProxy = dbProxy;
        this.Connection = dbProxy.Connection;
        this.Command = command;
        this.Command.Connection = this.Connection;
        this.Adapter = dbProxy.Adapter;
        this.CommandBuilder = dbProxy.CommandBuilder;
        this._tableName = tableName;
        this._dataSet = new DataSet();
    }

    public void CreateUpdateDelete()
    {
        var adapter = _dbProxy.Adapter;
        var commandBuilder = _dbProxy.CommandBuilder;

        adapter.Fill(_dataSet, _tableName);
        commandBuilder.GetUpdateCommand();
        commandBuilder.GetDeleteCommand();
        commandBuilder.GetInsertCommand();
        adapter.Update(_dataSet, _tableName);
    }

}