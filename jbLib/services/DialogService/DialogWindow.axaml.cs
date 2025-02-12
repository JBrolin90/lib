using Avalonia.Controls;

namespace jbLib.services.DialogService;


public interface IDialogWindow
{
    public event EventHandler? Closed;
    public bool Result { get; set; }
    void Show();
    void Close();
    object? Content { get; set; }
}
public partial class DialogWindow : Window, IDialogWindow
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public bool Result { get; set; } = false;
    public DialogWindow()
    {
        InitializeComponent();
    }
}