using System.Text.Json;
using Avalonia;
using Avalonia.Controls;

namespace jbLib.Avalonia.Utils;

public static class WindowSettingsManager
{
    private static string _settingsFileName = "windowSettings.json";
    private static string _settingsFilePath =
    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _settingsFileName);

    internal class WindowSettings
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public WindowState WindowState { get; set; }
    }
    public static void SaveWindowSettings(this Window window)
    {
        string windowKey = window.Name ?? throw new ArgumentException("Window must have name"); // Using the Name property as the window key
        var settings = LoadAllSettings();
        settings[windowKey] = new WindowSettings
        {
            Height = window.Height,
            Width = window.Width,
            Top = window.Position.Y,
            Left = window.Position.X,
            WindowState = window.WindowState
        };
        var json = JsonSerializer.Serialize(settings);
        File.WriteAllText(_settingsFilePath, json);
    }

    public static void LoadWindowSettings(this Window window, string? windowKey = null)
    {
        windowKey ??= window.Name;
        if (windowKey == null)
            throw new ArgumentException("Window must have name or windowKey must be provided");

        var settings = LoadAllSettings();
        if (settings.TryGetValue(windowKey, out var windowSettings))
        {
            window.Height = windowSettings.Height;
            window.Width = windowSettings.Width;
            window.Position = new PixelPoint(windowSettings.Left, windowSettings.Top);
            window.WindowState = windowSettings.WindowState;
        }
    }

    private static Dictionary<string, WindowSettings> LoadAllSettings()
    {
        if (File.Exists(_settingsFilePath))
        {
            var json = File.ReadAllText(_settingsFilePath);
            return JsonSerializer.Deserialize<Dictionary<string, WindowSettings>>(json) ?? new Dictionary<string, WindowSettings>();
        }
        return new Dictionary<string, WindowSettings>();
    }
}

