using ForNaviModule.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ForNaviModule
{
    public class ForNaviModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterForNavigation<AView>();
            containerRegistry.RegisterForNavigation<BView>();
        }

        public void OnInitialized(IContainerProvider containerProvider) {
        }
    }
}