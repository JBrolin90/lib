using System;
using System.Collections;
using System.Data;
using Avalonia.Controls;
using Avalonia.Data;

namespace jbLib.DataTableGrid;

public static class DataTableGridFactory
{
    static public DataGrid Produce(DataTable table)
    {
        ObservableDataTable<ObservableDataRow> tableList = new(table, row => new ObservableDataRow(row));
        DataGrid dataGrid = new()
        {
            ItemsSource = tableList,
            AutoGenerateColumns = false,
        };
        int i = 0;
        foreach (DataColumn column in table.Columns)
        {
            string header = column.Caption ?? column.ColumnName;
            string binder;
            if (column.DataType == typeof(int))
                binder = $"Int{i}";
            else if (column.DataType == typeof(string))
                binder = $"String{i}";
            else if (column.DataType == typeof(double))
                binder = $"Double{i}";
            else if (column.DataType == typeof(DateTime))
                binder = $"DateTime{i}";
            else
                binder = $"Object{i}";
            dataGrid.Columns.Add(new DataGridTextColumn { Header = header, Binding = new Binding(binder), IsReadOnly = column.ReadOnly });
            i++;
        }
        return dataGrid;
    }
}
