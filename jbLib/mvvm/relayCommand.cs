using System;
using System.Windows.Input;

namespace jbLib.mvvm;


public class RelayCommand(Action execute, Func<bool>? canExecute = null) : ICommand
{
    public event EventHandler? CanExecuteChanged;

    readonly Action _execute = execute;
    readonly Func<bool>? _canExecute = canExecute;

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object? parameter)
    {
        if (_canExecute != null)
            return _canExecute();
        else
            return true;
    }

    public void Execute(object? parameter)
    {
        _execute();
    }
}