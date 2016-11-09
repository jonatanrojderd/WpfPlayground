using System.Windows;
using Microsoft.Practices.Unity;
using WpfPlayground.IoC;
using WpfPlayground.Views;

namespace WpfPlayground
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IoCConfiguration.Register(IoCContainer.Instance);
            IoCContainer.Instance.Resolve<IMainWindow>().Show();
        }
    }
}
