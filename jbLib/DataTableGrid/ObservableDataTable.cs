using System.Collections;
using System.ComponentModel;
using System.Data;

namespace jbLib.DataTableGrid;

/// <summary>
/// Represents an observable wrapper around a DataTable, implementing IEnumerable<ObservableDataRow>.
/// </summary>
public class ObservableDataTable<T> : IEnumerable<T>, IReadOnlyList<T>, IList
where T : ObservableDataRow, new()
{
    public int Count => Rows.Count;
    public bool IsReadOnly => Rows.IsReadOnly; // NOT called by DataGrid during setup
    object? IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public T this[int index] => observableRows[index];
    private DataTable table;
    private List<T> observableRows = new();
    private readonly Func<DataRow, T> rowFactory;

    public ObservableDataTable(DataTable table, Func<DataRow, T> rowFactory)
    {
        this.table = table;
        this.rowFactory = rowFactory;
        foreach (DataRow row in table.Rows)
        {
            observableRows.Add(rowFactory(row));
        }
    }
    public void Add(T row)
    {
        observableRows.Add(row);
        table.Rows.Add(row.Row);
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T row in observableRows)
        {
            yield return row;
        }
    }



    public bool IsFixedSize => throw new NotImplementedException();
    public bool IsSynchronized => throw new NotImplementedException();
    public object SyncRoot => throw new NotImplementedException();

    public int Add(object? value) => throw new NotImplementedException();
    public void Clear() => throw new NotImplementedException();

    private DataRowCollection Rows => table.Rows;
    public bool Contains(object? value) => throw new NotImplementedException();

    public int IndexOf(object? value) => throw new NotImplementedException();

    public void Insert(int index, object? value) => throw new NotImplementedException();

    public void Remove(object? value) => throw new NotImplementedException();

    public void RemoveAt(int index) => throw new NotImplementedException();

    public void CopyTo(Array array, int index) => throw new NotImplementedException();

}
