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

    #region Constructors & Lifecycle
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

    #region Event Handling
    private void Table_ColumnChanged(object? sender, DataColumnChangeEventArgs e)
    {
        if (e.Row == row && e.Column != null)
        {
            HandleColumnChanged(e.Column, e.Column.Ordinal);
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    public DataRow Row => row;
    public bool IsReadOnly => false;
}