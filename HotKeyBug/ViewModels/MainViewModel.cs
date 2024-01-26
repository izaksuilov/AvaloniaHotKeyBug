namespace HotKeyBug.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public HeaderMenuViewModel HeaderMenuViewModel { get; set; } = new();
}