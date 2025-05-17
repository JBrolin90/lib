using System.Data;
using System.Data.Common;

namespace jbLib.DataAccess.Common;

public class DbDataAdapterWrapper : IDbDataAdapterWrapper
{
    private readonly DbDataAdapter _adapter;

    public DbDataAdapterWrapper(DbDataAdapter adapter)
    {
        _adapter = adapter;
    }

    public DbCommand? SelectCommand
    {
        get => _adapter.SelectCommand;
        set => _adapter.SelectCommand = value;
    }

    public int Fill(System.Data.DataSet dataSet, string srcTable)
    {
        return _adapter.Fill(dataSet, srcTable);
    }

    public int Update(System.Data.DataSet dataSet, string srcTable)
    {
        return _adapter.Update(dataSet, srcTable);
    }
}


