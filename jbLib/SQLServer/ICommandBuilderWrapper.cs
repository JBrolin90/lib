
namespace jbLib.SqlServer;

public interface ICommandBuilderWrapper
{
    System.Data.Common.DbCommand GetUpdateCommand();
    System.Data.Common.DbCommand GetDeleteCommand();
    System.Data.Common.DbCommand GetInsertCommand();
}