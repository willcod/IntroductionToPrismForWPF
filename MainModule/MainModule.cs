using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            //_regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewA));
            var region = _regionManager.Regions["MainRegion"];
            var view = containerProvider.Resolve<ViewA>();
            region.Add(view);

            //var anotherView = containerProvider.Resolve<ViewA>();
            //anotherView.Content = new TextBlock()
            //{
            //    Text = "Hello from another View",
            //    HorizontalAlignment = HorizontalAlignment.Center,
            //    VerticalAlignment = VerticalAlignment.Center,
            //    FontSize = 48
            //};

            //region.Add(anotherView);
            //region.Remove(view);
        }
    }
}
