using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsgInModule.Views;
using Prism.Regions;

namespace MsgInModule
{
    public class MsgInModule : IModule
    {
        private IRegionManager _regionManager;
        public MsgInModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MessageInRegion", typeof(MessageInputView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }
    }
}
