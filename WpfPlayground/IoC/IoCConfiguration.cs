using Microsoft.Practices.Unity;
using WpfPlayground.ViewModels;

namespace WpfPlayground.IoC
{
    public class IoCConfiguration
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IViewMainWindowViewModel, MainWindow>();
            container.RegisterType<IViewMainWindowViewModel, MainWindowViewModel>();
        }
    }
}
