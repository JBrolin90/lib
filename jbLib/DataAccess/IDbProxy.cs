using System.Data.Common;
using jbLib.DataAccess.Common;

namespace jbLib.DataAccess;

public interface IDbProxy
{
    DbConnection Connection { get; }
    DbCommand Command { get; }

    bool CheckCredentials();
    IDbDataAdapterWrapper Adapter { get; }
    public ICommandBuilderWrapper CommandBuilder { get; }

    public DbCommand BaseTablesCommand();

}
