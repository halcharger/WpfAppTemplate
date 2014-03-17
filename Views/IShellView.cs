using WpfAppTemplate.ViewModels;

namespace WpfAppTemplate.Views
{
    public interface IShellView
    {
        IShellViewModel ViewModel { get; set; }
    }
}