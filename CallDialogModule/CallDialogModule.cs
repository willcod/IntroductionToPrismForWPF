using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallDialogModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CallDialogModule
{
    public class CallDialogModule : IModule
    {
        private IRegionManager _regionManager;

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewCallingDialog));
        }

        public CallDialogModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
