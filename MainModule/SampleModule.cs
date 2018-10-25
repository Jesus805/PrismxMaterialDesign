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
            // This will throw an exception because "RightDrawerRegion" doesn't exist
            //regions["RightDrawerRegion"].Add(containerProvider.Resolve<RightDrawerView>());
            // However this works
            _manager.RegisterViewWithRegion("RightDrawerRegion", typeof(RightDrawerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {}
    }
}
