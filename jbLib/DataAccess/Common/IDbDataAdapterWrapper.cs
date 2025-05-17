using System.Data.Common;

namespace jbLib.DataAccess.Common;

public interface IDbDataAdapterWrapper
{
    int Fill(System.Data.DataSet dataSet, string srcTable);
    int Update(System.Data.DataSet dataSet, string srcTable);

    DbCommand? SelectCommand { get; set; }
}