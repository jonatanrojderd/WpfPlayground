using System.Windows;
using WpfPlayground.ViewModels;

namespace WpfPlayground
{
    public partial class MainWindow : Window, IViewMainWindowViewModel
    {
        public MainWindow(IViewMainWindowViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
