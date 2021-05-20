using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsgListModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MsgListModule
{
    public class MsgListModule : IModule
    {
        private IRegionManager _regionManager;

        public MsgListModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MessageListRegion", typeof(MessageListView));
        }
    }
}
