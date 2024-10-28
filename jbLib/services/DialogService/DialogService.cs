using Avalonia.Controls;

namespace jbLib.services.DialogService;

public class DialogService : IDialogService
{
    private readonly IDialogWindow? _dialog;
    public readonly Dictionary<Type, Type> Mappings = new();
    
    public DialogService(IDialogWindow? dialog)
    {
        _dialog = dialog;   
    }   

    public void RegisterDialog<TView, TViewModel>()
    {
        Mappings.Add(typeof(TViewModel), typeof(TView));
    }
    public void ShowDialog(string name, Action<string> callback)
    {
        var type = Type.GetType($"ShowingDialogs.Views.{name}");

        if (type != null) ShowDialogInternal(type, callback, null);
    }

    public void ShowDialog<TViewModel>(Action<string> callback)
    {
        var type = Mappings[typeof(TViewModel)];
        ShowDialogInternal(type, callback, typeof(TViewModel));
    }

    private void ShowDialogInternal(Type type, Action<string> callback, Type? vmType)
    {
        var dialog = _dialog ?? new DialogWindow() { Title = type.Name }  ;
        dialog.Closed += EventHandler;

        var content = Activator.CreateInstance(type) as Control ??
                      throw new InvalidOperationException("Could not create control");

        if (vmType is not null)
        {
            var vm = Activator.CreateInstance(vmType) ??
                     throw new InvalidOperationException("Could not create vm");
            content.DataContext = vm;
        }
        dialog.Content = content;

        dialog.Show();
        return;

        void EventHandler(object? sender, EventArgs e)
        {
            dialog.Closed -= EventHandler;
            callback(dialog.Result.ToString());
        }
    }
}
