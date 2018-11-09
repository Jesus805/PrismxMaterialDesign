using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PrismxMaterialDesign.MainModule
{
    class SampleModule : IModule
    {
        IRegionManager _manager;

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _manager = containerProvider.Resolve<IRegionManager>();
            var regions = _manager.Regions;
            regions["MainRegion"].Add(containerProvider.Resolve<MainView>());
            
            regions["RightDrawerRegion"].Add(containerProvider.Resolve<RightDrawerView>());

            regions["DialogHostRegion"].Add(containerProvider.Resolve<DialogView>());
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {}
    }
}
