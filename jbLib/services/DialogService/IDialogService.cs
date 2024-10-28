namespace jbLib.services.DialogService;

public interface IDialogService
{
    void ShowDialog(string name, Action<string> callback);
    void ShowDialog<TViewModel>(Action<string> callback);
}