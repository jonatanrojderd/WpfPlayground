using System.Windows;
using Microsoft.Practices.Unity;
using WpfPlayground.IoC;

namespace WpfPlayground
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IoCConfiguration.Register(IoCContainer.Instance);
            IoCContainer.Instance.Resolve<MainWindow>().Show();
        }
    }
}
