using System.Data.Common;

namespace jbLib.SqlServer;

public interface IDbProxy
{
    DbConnection Connection { get; }
    DbCommand Command { get; }

    bool CheckCredentials();
    IDbDataAdapterWrapper Adapter { get; }
    public ICommandBuilderWrapper CommandBuilder { get; }

    public DbCommand BaseTablesCommand();

}
