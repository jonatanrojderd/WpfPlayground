using Microsoft.Practices.Unity;
using WpfPlayground.Models;
using WpfPlayground.ViewModels;
using WpfPlayground.Views;

namespace WpfPlayground.IoC
{
    public class IoCConfiguration
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IMainWindowViewModel, MainWindow>();
            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            container.RegisterType<IPersonRepository, PersonRepository>();
        }
    }
}
