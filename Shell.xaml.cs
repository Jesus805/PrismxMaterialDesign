using Prism.Regions;
using System.Windows;

namespace PrismxMaterialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell(IRegionManager manager)
        {
            InitializeComponent();

            SetRegionManager(manager, RightDrawer, "RightDrawerRegion");
            SetRegionManager(manager, Dialog, "DialogHostRegion");
        }

        public void SetRegionManager(IRegionManager manager, DependencyObject regionTarget, string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, manager);
        }
    }
}
