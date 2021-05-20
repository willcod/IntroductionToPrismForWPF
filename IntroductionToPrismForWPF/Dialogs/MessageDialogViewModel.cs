using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace IntroductionToPrismForWPF.Dialogs
{
    public class MessageDialogViewModel : BindableBase, IDialogAware
    {
        private string _message;

        public DelegateCommand CloseCommand { get; set; }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MessageDialogViewModel()
        {
            CloseCommand = new DelegateCommand(Closed);
        }

        private void Closed()
        {
            var result = ButtonResult.OK;

            var p = new DialogParameters();
            p.Add("myParam", "The dialog was closed by the user");

            RequestClose?.Invoke(new DialogResult(result, p));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }

        public string Title => "Hello";
        public event Action<IDialogResult> RequestClose;
    }
}
