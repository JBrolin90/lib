using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace jbLib.DataTableGrid;

/// <summary>
/// Represents an observable row of data, wrapping a DataRow with ObservableDataCell objects.
/// </summary>
public partial class ObservableDataRow : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    #region called during setup before connecting to ItemsSource
    public ObservableDataRow()
    {
    }
    public ObservableDataRow(DataRow row)
    {
        this.row = row;
        row.Table.ColumnChanged += Table_ColumnChanged;
    }
    #endregion
    #region NotUsedByDataGrid
    public DataRow Row => row;
    private void Table_ColumnChanged(object sender, DataColumnChangeEventArgs e)
    {
        if (e.Row == row && e.Column != null) // e.Column is null when the row is deleted
        {
            string columnName = e.Column.ColumnName;
            int ordinal = e.Column.Ordinal;
            if (e.Column.DataType == typeof(int))
            {
                OnPropertyChanged($"Int{ordinal}");
            }
            if (e.Column.DataType == typeof(double))
            {
                OnPropertyChanged($"Double{ordinal}");
            }
            if (e.Column.DataType == typeof(string))
            {
                OnPropertyChanged($"String{ordinal}");
            }
            if (e.Column.DataType == typeof(DateTime))
            {
                OnPropertyChanged($"DateTime{ordinal}");
            }
        }
    }
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public bool IsReadOnly => false;
    #endregion

}