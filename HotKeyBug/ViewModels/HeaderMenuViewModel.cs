using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Windows.Input;

namespace HotKeyBug.ViewModels
{
    public class HeaderMenuViewModel : ViewModelBase
    {
        public HeaderMenuViewModel()
        {
            TestCommand = ReactiveCommand.Create(() => CommandCount++);
        }

        public ICommand TestCommand { get; }

        [Reactive]
        public int CommandCount { get; set; }
    }
}