using Autofac;
using WpfAppTemplate.Autofac;
using WpfAppTemplate.Controllers;
using WpfAppTemplate.ViewModels;
using WpfAppTemplate.Views;

namespace WpfAppTemplate
{
    public class MainAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainPrismModule>();
            builder.RegisterSingleton<IMainController, MainController>();
            builder.RegisterSingleton<IMainViewModel, MainViewModel>();
            builder.RegisterSingleton<IMainView, MainView>();
        }
    }
}