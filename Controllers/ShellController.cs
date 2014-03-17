using System.Reflection;
using WpfAppTemplate.ViewModels;
using WpfAppTemplate.Views;

namespace WpfAppTemplate.Controllers
{
    public interface IShellController
    {
        void Run();
    }

    public class ShellController : IShellController
    {
        private readonly IShellViewModel _shellViewModel;
        private readonly IShellView _shellView;
        private readonly IMainController _mainController;

        public ShellController(
            IShellViewModel shellViewModel,
            IShellView shellView,
            IMainController mainController)
        {
            _shellViewModel = shellViewModel;
            _shellView = shellView;
            _mainController = mainController;
            _shellView.ViewModel = _shellViewModel;
        }

        public void Run()
        {
            //Set window icon below
            //((Window)_shellView).Icon = new BitmapImage(
            //    new Uri("pack://application:,,,/WpfAppTemplate;component/Themes/Images/im-logo-static.png"));

            _shellViewModel.TitleText = "Your app title goes here";
            _shellViewModel.Version = string.Format("v {0}", Assembly.GetEntryAssembly().GetName().Version);

            _mainController.Run();
        }
    }
}