using System;
using System.Windows;

namespace WpfAppTemplate
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += AppDomainUnhandledException;

            base.OnStartup(e);
            var bootstrapper = new BootStrapper();
            bootstrapper.Run();
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null) return;

            MessageBox.Show(ex.ToString());
            Environment.Exit(1);
        }
    }
}
