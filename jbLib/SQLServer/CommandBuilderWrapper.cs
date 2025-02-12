using System;
using System.Data.Common;

namespace jbLib.SqlServer;

public class CommandBuilderWrapper : ICommandBuilderWrapper
{
    private readonly DbCommandBuilder _commandBuilder;

    public CommandBuilderWrapper(DbCommandBuilder commandBuilder)
    {
        _commandBuilder = commandBuilder;
    }

    public DbCommand GetUpdateCommand()
    {
        return _commandBuilder.GetUpdateCommand();
    }

    public DbCommand GetDeleteCommand()
    {
        return _commandBuilder.GetDeleteCommand();
    }

    public DbCommand GetInsertCommand()
    {
        return _commandBuilder.GetInsertCommand();
    }
}