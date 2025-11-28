# DataTableGrid

Kudos to [@timunie](https://github.com/timunie) who came up with the idea to wrap each row and use generated typed properties for binding in an indexed scenario.

## Overview

This library provides a solution for binding `System.Data.DataTable` to Avalonia's `DataGrid` control. Since Avalonia's binding system requires compile-time property names, this project generates typed properties (e.g., `Int0`, `String1`, `DateTime2`) for each column index, enabling seamless two-way data binding.

## Architecture

```
DataTableGridFactory.Produce(DataTable)
    └── Creates ObservableDataTable<ObservableDataRow>
            └── Wraps each DataRow in ObservableDataRow
                    └── Exposes typed properties (Int0, String0, Bool0, etc.)
```

## Components

### 1. DataTableGridFactory

A static factory class that creates a fully configured `DataGrid` from a `DataTable`.

**Key Features:**
- Automatic column generation based on `DataTable` schema
- Type-aware binding (maps column types to appropriate property prefixes)
- Uses column `Caption` for headers, falling back to `ColumnName`

**Usage:**
```csharp
DataTable table = GetMyData();
DataGrid grid = DataTableGridFactory.Produce(table);
```

**Supported Column Types:**
| .NET Type | Property Prefix | Example Binding |
|-----------|-----------------|-----------------|
| `int` | `Int` | `Int0`, `Int1` |
| `bool` | `Bool` | `Bool0`, `Bool1` |
| `string` | `String` | `String0`, `String1` |
| `double` | `Double` | `Double0`, `Double1` |
| `DateTime` | `DateTime` | `DateTime0`, `DateTime1` |
| `decimal` | `Decimal` | `Decimal0`, `Decimal1` |
| `long` | `Long` | `Long0`, `Long1` |
| `Guid` | `Guid` | `Guid0`, `Guid1` |
| Other | `Object` | `Object0`, `Object1` |

### 2. ObservableDataTable\<T\>

A generic collection that wraps a `DataTable` and provides observable row access.

**Key Features:**
- Implements `IEnumerable<T>`, `IReadOnlyList<T>`, and `IList`
- Uses a factory function to create row wrappers
- Maintains synchronization with underlying `DataTable`

**Constructor:**
```csharp
public ObservableDataTable(DataTable table, Func<DataRow, T> rowFactory)
```

### 3. ObservableDataRow

A partial class that wraps a `DataRow` and provides:
- Type-safe property access via generated properties
- `INotifyPropertyChanged` implementation for UI updates
- `IDisposable` for proper event cleanup

**Files:**
- `ObservableDataRow.cs` - Core logic, accessors, and event handling
- `ObservableDataRow.Properties.cs` - Auto-generated properties (do not edit)
- `ObservableDataRow.Properties.tt` - T4 template for code generation

**Safe Accessors:**
```csharp
// For value types (int, bool, double, DateTime, etc.)
private T? GetValue<T>(int index) where T : struct

// For reference types (string, object)
private T? GetRefValue<T>(int index) where T : class
```

These accessors provide:
- Bounds checking (returns `null` if index exceeds column count)
- `DBNull` handling (converts to/from `null`)
- Safe type casting

## Code Generation

Properties are generated using a T4 template (`ObservableDataRow.Properties.tt`).

### Adding a New Type

1. Edit the `.tt` file and add your type to the appropriate array:
```csharp
var valueTypes = new[] { "int", "bool", "double", "DateTime", "Guid", "decimal", "long", "short" };  // Add here
var refTypes = new[] { "string", "object", "byte[]" };  // Or here for reference types
```

2. Regenerate the properties file:
```bash
dotnet tool install -g dotnet-t4  # First time only
t4 ObservableDataRow.Properties.tt -o ObservableDataRow.Properties.cs
```

The template automatically generates:
- 256 properties per type (indices 0-255)
- The `HandleColumnChanged` event handler

### Generated Output

For each type and index, the template generates:
```csharp
public int? Int0 { get => GetValue<int>(0); set => SetValue(0, value); }
public string? String0 { get => GetRefValue<string>(0); set => SetRefValue(0, value); }
// ... up to index 255
```

## Limitations

- Maximum 256 columns supported
- All properties are nullable to handle `DBNull`
- Type mismatch at runtime may return `null` (no exception thrown)

## Example

```csharp
// Create a DataTable
var table = new DataTable();
table.Columns.Add("Id", typeof(int));
table.Columns.Add("Name", typeof(string));
table.Columns.Add("Active", typeof(bool));
table.Rows.Add(1, "Alice", true);
table.Rows.Add(2, "Bob", false);

// Create the DataGrid
DataGrid grid = DataTableGridFactory.Produce(table);

// The grid now has columns bound to:
// - Int0 (Id)
// - String1 (Name)  
// - Bool2 (Active)
```

## Dependencies

- Avalonia.Controls.DataGrid
- System.Data (DataTable, DataRow, etc.)



## Key Features

- Binding DataGrid columns to named properties 
- Binding DataGrid columns to indexed properties, facilating dynamic binding
- Demonstration of two-way binding behavior
- Customizable DataGrid setup

## Binding Behavior

The project demonstrates two different binding approaches:

1. **Named Property Binding**: 
   - Columns bound to `Name` and `Age` properties
   - Responds correctly to PropertyChanged events
   - DataGrid automatically sets IsReadOnly based on the IList.IsReadOnly property

2. **Indexed Property Binding**:
   - Columns bound to `[0]` and `[1]` indexed properties
   - Responds correctly to PropertyChanged events
   - DataGrid automatically sets IsReadOnly based on the IList.IsReadOnly property

## Usage


To use the DataTableGridView control in your project, follow these steps:

1. First, make sure you have a DataTable that you want to display. This could be created programmatically or loaded from a data source.

2. Create an instance of the DataTableGridView, passing your DataTable to its constructor:

   ```csharp
   DataTable myDataTable = // ... your DataTable creation or loading logic
   DataTableGridView gridView = new DataTableGridView(myDataTable);
   ```

3. The DataTableGridView will automatically set up the DataGrid with columns based on your DataTable structure. It uses the ObservableDataTable internally to wrap your DataTable and make it observable.

4. You can now use this gridView in your Avalonia UI. For example, you might set it as the Content of a Window or add it to a parent control:

   ```csharp
   // If using it directly in a Window
   this.Content = gridView;

   // Or if adding to another control
   parentControl.Children.Add(gridView);
   ```

5. The DataTableGridView handles the column generation automatically. It will create columns based on the DataTable structure, using the column names as headers.

6. The control uses indexed property binding internally (`[{column.Ordinal}].Value`), which allows for flexible and dynamic binding regardless of the column position in the table.

7. You don't need to manually set up bindings or create columns - the DataTableGridView handles this for you based on the DataTable structure.

8. The resulting grid will support two-way binding, meaning changes in the UI will be reflected in the underlying DataTable, and vice versa.

Here's a complete example of how you might use it in a Window class:

```csharp
public class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Create or load your DataTable
        DataTable myDataTable = CreateSampleDataTable();

        // Create the DataTableGridView
        DataTableGridView gridView = new DataTableGridView(myDataTable);

        // Set it as the content of the window
        this.Content = gridView;
    }

    private DataTable CreateSampleDataTable()
    {
        DataTable table = new DataTable();
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Age", typeof(int));
        table.Rows.Add("Alice", 30);
        table.Rows.Add("Bob", 25);
        return table;
    }
}
```

This approach encapsulates the complexity of setting up a DataGrid for a DataTable, providing a simple interface for developers to use. The DataTableGridView handles the creation of the ObservableDataTable, sets up the necessary bindings, and manages the column generation, making it easy to display and interact with tabular data in your Avalonia UI application.

