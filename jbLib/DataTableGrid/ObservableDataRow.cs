using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace jbLib.DataTableGrid;

/// <summary>
/// Represents an observable row of data, wrapping a DataRow with ObservableDataCell objects.
/// </summary>
public partial class ObservableDataRow : INotifyPropertyChanged, IDisposable
{
    private DataRow row = null!;
    private bool _disposed;

    public event PropertyChangedEventHandler? PropertyChanged;

    #region called during setup before connecting to ItemsSource
    public ObservableDataRow()
    {
    }

    public ObservableDataRow(DataRow row)
    {
        Initialize(row);
    }

    public void Initialize(DataRow dataRow)
    {
        this.row = dataRow ?? throw new ArgumentNullException(nameof(dataRow));
        row.Table.ColumnChanged += Table_ColumnChanged;
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            if (row?.Table != null)
                row.Table.ColumnChanged -= Table_ColumnChanged;
            _disposed = true;
        }
    }
    #endregion

    #region Safe Accessors
    private T? GetValue<T>(int index) where T : struct
    {
        if (row == null || index >= row.Table.Columns.Count)
            return null;
        return row[index] == DBNull.Value ? null : (T)row[index];
    }

    private T? GetRefValue<T>(int index) where T : class
    {
        if (row == null || index >= row.Table.Columns.Count)
            return null;

        var value = row[index];
        if (value == DBNull.Value)
            return null;

        // For object type, return as-is; for specific types, cast
        if (typeof(T) == typeof(object))
            return (T)value;

        return value is T typed ? typed : null;
    }

    private void SetValue<T>(int index, T? value) where T : struct
    {
        if (row == null || index >= row.Table.Columns.Count)
            return;
        row[index] = value.HasValue ? value.Value : DBNull.Value;
    }

    private void SetRefValue<T>(int index, T? value) where T : class
    {
        if (row == null || index >= row.Table.Columns.Count)
            return;
        row[index] = value ?? (object)DBNull.Value;
    }
    #endregion

    #region NotUsedByDataGrid
    public DataRow Row => row;

    private void Table_ColumnChanged(object sender, DataColumnChangeEventArgs e)
    {
        if (e.Row == row && e.Column != null)
        {
            int ordinal = e.Column.Ordinal;
            if (e.Column.DataType == typeof(int))
                OnPropertyChanged($"Int{ordinal}");
            else if (e.Column.DataType == typeof(bool))
                OnPropertyChanged($"Bool{ordinal}");
            else if (e.Column.DataType == typeof(double))
                OnPropertyChanged($"Double{ordinal}");
            else if (e.Column.DataType == typeof(string))
                OnPropertyChanged($"String{ordinal}");
            else if (e.Column.DataType == typeof(DateTime))
                OnPropertyChanged($"DateTime{ordinal}");
            else if (e.Column.DataType == typeof(Object))
                OnPropertyChanged($"Object{ordinal}");
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public bool IsReadOnly => false;
    #endregion

}