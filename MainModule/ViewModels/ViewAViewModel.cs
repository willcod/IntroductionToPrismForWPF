using Prism.Commands;
using Prism.Mvvm;

namespace MainModule.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _title = "";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canExecute = false;

        public bool CanExecute {
            get { return _canExecute; }
            set {
                SetProperty(ref _canExecute, value);
            }
        }

        public DelegateCommand ClickCommand { get; private set; }

        public ViewAViewModel() {
            Title = "Hello from ViewAViewModel";
            ClickCommand = new DelegateCommand(Click).ObservesCanExecute(() => CanExecute);
        }

        private void Click() {
            Title = "Clicked me";
        }
    }
}