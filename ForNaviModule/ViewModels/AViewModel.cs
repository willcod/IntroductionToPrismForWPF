using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;

namespace ForNaviModule.ViewModels
{
    public class AViewModel : BindableBase, INavigationAware
    {
        private int _viewCount = 0;

        public int ViewCount
        {
            get
            {
                return _viewCount;
            }
            set
            {
                SetProperty(ref _viewCount, value);
            }
        }

        public AViewModel()
        {
            ViewCount = 0;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            ViewCount++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
