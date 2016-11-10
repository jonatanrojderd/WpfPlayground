using Microsoft.Practices.Unity;
using WpfPlayground.ViewModels;

namespace WpfPlayground.Views
{
    public partial class MainWindow : IMainWindow
    {
        [Dependency]
        public IMainWindowViewModel ViewModel
        {
            set { DataContext = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
