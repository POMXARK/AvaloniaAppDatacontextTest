using ReactiveUI.Fody.Helpers;

namespace AvaloniaAppDatacontextTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        public NextViewModel NextVM => new();
    }
}
