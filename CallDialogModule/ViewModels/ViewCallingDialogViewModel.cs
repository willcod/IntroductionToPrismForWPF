using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace CallDialogModule.ViewModels
{
    public class ViewCallingDialogViewModel : BindableBase
    {
        private IDialogService _dialogService;
        public DelegateCommand CallDialogCommand { get; set; }

        public ViewCallingDialogViewModel(IDialogService dialogService) {
            CallDialogCommand = new DelegateCommand(ShowDialog);
            _dialogService = dialogService;
        }

        private void ShowDialog() {
            var p = new DialogParameters();
            p.Add("message", "hello from Mars");
            _dialogService.ShowDialog("MessageDialog", p, result => {
                if (result.Result == ButtonResult.OK) {
                    var q = new DialogParameters();
                    q.Add("message", result.Parameters.GetValue<string>("myParam"));
                    _dialogService.ShowDialog("MessageDialog", q, null);
                }
            });
        }
    }
}