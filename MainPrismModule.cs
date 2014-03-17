using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using WpfAppTemplate.Views;

namespace WpfAppTemplate
{
    public class MainPrismModule : IModule
    {
        private readonly IRegionManager _regionmanager;
        private readonly IMainView _mainView;

        public MainPrismModule(IRegionManager regionmanager, IMainView mainView)
        {
            _regionmanager = regionmanager;
            _mainView = mainView;
        }

        public void Initialize()
        {
            _regionmanager.AddToRegion(RegionNames.MainRegion, _mainView);
        }
    }
}