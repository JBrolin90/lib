# jbLib

## Overview
`jbLib` is a .NET library designed to provide MVVM utilities and SQL Server table management functionalities. This library includes observable objects, relay commands, and classes for interacting with SQL Server base tables.

## Project Structure



## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Building the Project
To build the project, navigate to the root directory and run:
```sh
dotnet build [lib.sln](http://_vscodecontentref_/#%7B%22uri%22%3A%7B%22%24mid%22%3A1%2C%22fsPath%22%3A%22%2Fhome%2Fjoachim%2Flab%2Flib%2Flib.sln%22%2C%22path%22%3A%22%2Fhome%2Fjoachim%2Flab%2Flib%2Flib.sln%22%2C%22scheme%22%3A%22file%22%7D%7D)


Running Tests
To run the tests, navigate to the jbLib.Tests directory and run:

Project Components
MVVM Utilities:
    observableObject.cs:    Implements the INotifyPropertyChanged interface to provide property change notifications.
    relayCommand.cs:        Implements the ICommand interface to handle command logic.
SQL Server Utilities
    BaseTables.cs:          Provides base functionality for SQL Server table interactions.
    ClassFromTable.cs:      Represents a class generated from a SQL Server table.

Contributing
    Contributions are welcome! Please fork the repository and submit a pull request.

License
This project is licensed under the MIT License. See the LICENSE file for details.

