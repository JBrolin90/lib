namespace jbLib.services.DialogService;

public interface IDialogService
{
    static abstract void RegisterDialog<TView, TViewModel>();
    void ShowDialog(string name, Action<string> callback);
    void ShowDialog<TViewModel>(Action<string> callback);
    void CloseDialog();
}