using Avalonia.Controls;

namespace jbLib.services.DialogService;

public class DialogService : IDialogService, IDisposable
{
    private IDialogWindow? _dialogContainer;
    private static readonly Dictionary<Type, Type> Mappings = new();

    public DialogService(IDialogWindow? dialog = null)
    {
        _dialogContainer = dialog;
    }

    public static void RegisterDialog<TView, TViewModel>()
    {
        Mappings.Add(typeof(TViewModel), typeof(TView));
    }
    public void ShowDialog(string name, Action<string> callback)
    {
        var type = Type.GetType($"ShowingDialogs.Views.{name}");

        if (type != null) ShowDialogInternal(type, callback);
    }

    public void ShowDialog<TViewModel>(Action<string> callback)
    {
        var modelType = typeof(TViewModel);
        var type = Mappings[modelType];
        ShowDialogInternal(type, callback, typeof(TViewModel));
    }

    public void CloseDialog()
    {
        _dialogContainer?.Close();
        _dialogContainer = null;
    }

    private void ShowDialogInternal(Type type, Action<string> callback, Type? vmType = null)
    {
        _dialogContainer ??= new DialogWindow() { Title = type.Name };
        _dialogContainer.Closed += EventHandler;

        var content = Activator.CreateInstance(type) as Control ??
                      throw new InvalidOperationException("Could not create control");

        if (vmType is not null)
        {
            var vm = Activator.CreateInstance(vmType) ??
                     throw new InvalidOperationException("Could not create vm");
            content.DataContext = vm;
        }
        _dialogContainer.Content = content;

        _dialogContainer.Show();
        return;

        void EventHandler(object? sender, EventArgs e)
        {
            _dialogContainer.Closed -= EventHandler;
            callback(obj: _dialogContainer.Result.ToString());
        }
    }

    public void Dispose()
    {
        _dialogContainer?.Close();
    }
}
