using IntroductionToPrismForWPF.Core.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace MsgInModule.ViewModels
{
    public class MessageInputViewModel : BindableBase
    {
        private string _message;

        public string Message {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendMessageCommand { get; private set; }

        private IEventAggregator _eventeAggregator;

        public MessageInputViewModel(IEventAggregator eventAggregator) {
            SendMessageCommand = new DelegateCommand(SendMessage);
            _eventeAggregator = eventAggregator;
        }

        private void SendMessage() {
            _eventeAggregator.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}