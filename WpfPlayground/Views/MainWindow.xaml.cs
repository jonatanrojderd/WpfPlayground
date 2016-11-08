using Microsoft.Practices.Unity;
using WpfPlayground.ViewModels;

namespace WpfPlayground.Views
{
    public partial class MainWindow : IMainWindowViewModel
    {
        [Dependency]
        public MainWindowViewModel ViewModel
        {
            set { DataContext = value; }
        }

        public MainWindow(/*IMainWindowViewModel mainWindowViewModel*/)
        {
            InitializeComponent();
            //DataContext = mainWindowViewModel;
        }
    }
}
