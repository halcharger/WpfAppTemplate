using System.IO;
using System.Windows;
using Autofac;
using log4net.Config;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Prism.AutofacExtension;
using WpfAppTemplate.Autofac;
using WpfAppTemplate.Controllers;
using WpfAppTemplate.ViewModels;
using WpfAppTemplate.Views;

namespace WpfAppTemplate
{
    public class BootStrapper : AutofacBootstrapper
    {
        private const string Log4NetConfigFile = "log4net.config";

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);

            SetupLogging();

            RegisterShellTypes(builder);

            builder.RegisterModule<MainAutofacModule>();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var mainModuleType = typeof(MainPrismModule);
            ModuleCatalog.AddModule(new ModuleInfo(
                mainModuleType.Name, mainModuleType.AssemblyQualifiedName));
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<IShellView>() as DependencyObject;
        }

        private void RegisterShellTypes(ContainerBuilder builder)
        {
            builder.RegisterSingleton<IEventAggregator, EventAggregator>();

            builder.RegisterSingleton<IShellController, ShellController>();
            builder.RegisterSingleton<IShellViewModel, ShellViewModel>();
            builder.RegisterSingleton<IShellView, ShellView>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (ShellView)Shell;
            Application.Current.MainWindow.Show();

            Container.Resolve<IShellController>().Run();
        }

        private void SetupLogging()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Log4NetConfigFile));
        }

    }
}