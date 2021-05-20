using IntroductionToPrismForWPF.Core.Events;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MsgListModule.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private ObservableCollection<string> _messages = new ObservableCollection<string>();

        public ObservableCollection<string> Messages {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        public MessageListViewModel(IEventAggregator eventAggregator) {
            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(string msg) {
            Messages.Add(msg);
        }
    }
}