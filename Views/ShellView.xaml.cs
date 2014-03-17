using System.Windows;
using System.Windows.Input;
using WpfAppTemplate.ViewModels;

namespace WpfAppTemplate.Views
{
    public partial class ShellView : IShellView
    {
        private readonly Thickness _normalWindowMargin = new Thickness(0);
        private readonly Thickness _maximizedWindowMargin = new Thickness(8);

        public ShellView()
        {
            InitializeComponent();

            SizeChanged += OnSizeChanged;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs sizeChangedEventArgs)
        {
            FullScreenPresenter.Margin = WindowState == WindowState.Maximized
                ? _maximizedWindowMargin
                : _normalWindowMargin;
        }

        public IShellViewModel ViewModel
        {
            get { return DataContext as IShellViewModel; }
            set { DataContext = value; }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                DragMove();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ToggleFullScreen(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
