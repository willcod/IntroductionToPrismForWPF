using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MainModule
{
    public class MainModule : IModule
    {
        private IRegionManager _regionManager;
        public MainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewA));
        }
    }
}
