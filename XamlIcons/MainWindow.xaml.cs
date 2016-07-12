using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Controls;
using XamlIcons.Model;
using XamlIcons.ViewModel;

namespace XamlIcons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new MainWindowViewModel();

            DataContext = _viewModel;
        }

        private void IconClicked(object sender, RoutedEventArgs e)
        {
            _viewModel.SelectedIcon = (IconModel)((Button)sender).DataContext;
        }
    }
}
