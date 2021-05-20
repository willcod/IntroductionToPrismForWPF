using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace IntroductionToPrismForWPF.ViewModels
{
    public class NavigationViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        public DelegateCommand<string> NavigationCommand { set; get; }

        public NavigationViewModel(IRegionManager regionManager)
        {
            NavigationCommand = new DelegateCommand<string>(Navigate);
            _regionManager = regionManager;
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("MainRegion", uri);
        }
    }
}
