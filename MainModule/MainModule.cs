using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MainModule.Controls;
using MainModule.ViewModels;
using MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
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
            //ViewModelLocationProvider.Register<ControlA, ControlAViewModel>();
            ViewModelLocationProvider.Register<ControlA>(() =>
            {
                return new ControlAViewModel()
                {
                    Title = "Hello from factory"
                };
            });
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewA));
        }
    }
}
