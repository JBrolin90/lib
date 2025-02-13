# jbLib

## Overview

The `jbLib` project is a .NET 8 library designed to provide a set of reusable components and services for Avalonia UI applications. It includes modules for data handling, UI enhancements, and service implementations.

## Project Structure

-   **Avalonia**: Contains utility classes and extensions for Avalonia UI, such as window settings management.
-   **DataTableGrid**: Provides custom controls and classes for displaying and interacting with `DataTable` objects in an Avalonia UI `DataGrid`.
-   **DialogService**: Implements a dialog service for displaying modal windows in Avalonia UI applications.
-   **LoginService**: Offers services and UI components for handling user login functionality.
-   **MessengerService**: Implements a messenger service for loosely coupled communication between different parts of the application.
-   **MVVM**: Contains base classes and interfaces for implementing the Model-View-ViewModel (MVVM) pattern.
-   **SQLServer**: Provides classes and interfaces for interacting with SQL Server databases.

## Key Components

### DataTableGrid

The `DataTableGrid` module provides a way to display and interact with tabular data using the Avalonia UI `DataGrid` control.

#### Key Features

-   **Data Binding**: Binds `DataGrid` columns to named and indexed properties.
-   **Two-Way Binding**: Demonstrates two-way binding behavior between the `DataGrid` and the underlying data.
-   **Customizable Setup**: Offers customizable `DataGrid` setup.

#### Components

-   **DataTableGridView**: Encapsulates the complexity of setting up a `DataGrid` for a `DataTable`.
-   **ObservableDataTable**: Serves as a bridge between the raw data in a `DataTable` and the observable collection needed for responsive UI.
-   **ObservableDataRow**: Encapsulates a single row of data from the `DataTable`, providing an observable interface to the row's data.
-   **ObservableDataCell**: Represents an individual cell within an `ObservableDataRow` as an observable cell.

#### Usage

1.  Create a `DataTable` instance.
2.  Create an instance of the `DataTableGridView`, passing your `DataTable` to its constructor.
3.  Set the `DataTableGridView` as the content of a window or add it to a parent control.

### DialogService

The `DialogService` module provides a way to display modal dialog windows in Avalonia UI applications.

#### Key Features

-   **Dialog Registration**: Allows registering views and view models for dialogs.
-   **Show Dialog**: Displays a dialog window based on a view model type.
-   **Close Dialog**: Closes the currently open dialog window.

#### Components

-   **IDialogService**: Defines the interface for the dialog service.
-   **DialogService**: Implements the `IDialogService` interface.
-   **DialogWindow**: Represents the dialog window.

#### Usage

1.  Register the dialog view and view model using `DialogService.RegisterDialog<TView, TViewModel>()`.
2.  Show the dialog using `dialogService.ShowDialog<TViewModel>(callback)`.
3.  Close the dialog using `dialogService.CloseDialog()`.

### LoginService

The `LoginService` module provides services and UI components for handling user login functionality.

#### Key Features

-   **Login**: Authenticates users against a database.
-   **Interactive Login**: Provides a dialog for users to enter their credentials.

#### Components

-   **LoginService**: Manages the login process.
-   **LoginViewModel**: Represents the view model for the login UI.
-   **LoginWindow**: Represents the login window.
-   **LoginControl**: Represents the login control.
-   **CredentialsModel**: Represents the user credentials.
-   **DatabaseLoginModel**: Represents the database login model.

#### Usage

1.  Create an instance of the `LoginService`.
2.  Call the `LoginInteractive()` method to display the login dialog.

### MessengerService

The `MessengerService` module implements a messenger service for loosely coupled communication between different parts of the application.

#### Key Features

-   **Send**: Sends a message to all subscribers.
-   **Subscribe**: Subscribes to a specific message type.
-   **Unsubscribe**: Unsubscribes from a specific message type.

#### Components

-   **IMessenger**: Defines the interface for the messenger service.
-   **Messenger**: Implements the `IMessenger` interface.

#### Usage

1.  Subscribe to a message type using `Messenger.Subscribe<TMessage>(subscriber, action)`.
2.  Send a message using `Messenger.Send<TMessage>(message)`.
3.  Unsubscribe from a message type using `Messenger.UnSubscribe<TMessage>(subscriber)`.

### SQLServer

The `SQLServer` module provides classes and interfaces for interacting with SQL Server databases.

#### Key Features

-   **Database Connection**: Establishes a connection to a SQL Server database.
-   **Table Operations**: Provides methods for reading, creating, updating, and deleting data in tables.
-   **Class Generation**: Generates C# classes from database tables.

#### Components

-   **IDbProxy**: Defines the interface for a database proxy.
-   **SqlServerProxy**: Implements the `IDbProxy` interface for SQL Server.
-   **DbTableCrud**: Provides methods for performing CRUD operations on database tables.
-   **ClassFromTable**: Generates C# classes from database tables.
-   **BaseTables**: Retrieves all base tables from the database.
-   **IDbDataAdapterWrapper**: Defines the interface for a database data adapter wrapper.
-   **DbDataAdapterWrapper**: Implements the `IDbDataAdapterWrapper` interface.
-   **ICommandBuilderWrapper**: Defines the interface for a command builder wrapper.
-   **CommandBuilderWrapper**: Implements the `ICommandBuilderWrapper` interface.

#### Usage

1.  Create an instance of the `SqlServerProxy`, passing the connection string.
2.  Use the `DbTableCrud` class to perform CRUD operations on database tables.
3.  Use the `ClassFromTable` class to generate C# classes from database tables.

## Dependencies

-   Avalonia.Controls.DataGrid
-   Microsoft.Data.SqlClient
-   System.Collections.Concurrent
-   System.ServiceModel.Primitives
-   xunit

## Getting Started

1.  Clone the repository.
2.  Open the solution in Visual Studio.
3.  Build the project.
4.  Use the components and services in your Avalonia UI application.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues.
