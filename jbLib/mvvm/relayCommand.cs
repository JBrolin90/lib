using System;
using System.Windows.Input;

namespace jbLib.mvvm;


public class RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null) : ICommand
{
    public event EventHandler? CanExecuteChanged;

    readonly Action<object?> _execute = execute;
    readonly Func<object?, bool>? _canExecute = canExecute;

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object? parameter)
    {
        if (_canExecute != null)
            return _canExecute(parameter);
        else
            return true;
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}