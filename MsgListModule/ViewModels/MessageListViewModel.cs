using IntroductionToPrismForWPF.Core.Events;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MsgListModule.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private ObservableCollection<string> _messages = new ObservableCollection<string>();
        private bool _isSubscribed;

        public ObservableCollection<string> Messages {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        private MessageSentEvent _evt;
        private SubscriptionToken _token;

        public bool IsSubscribed {
            get { return _isSubscribed; }
            set {
                SetProperty(ref _isSubscribed, value);
                if (IsSubscribed) {
                    _token = _evt.Subscribe(MessageReceived);
                }
                else {
                    _evt.Unsubscribe(_token);
                }
            }
        }

        public MessageListViewModel(IEventAggregator eventAggregator) {
            _evt = eventAggregator.GetEvent<MessageSentEvent>();
            IsSubscribed = true;
        }

        private void MessageReceived(string msg) {
            Messages.Add(msg);
        }

    }
}