using System.Collections.ObjectModel;
using XamlIcons.Model;

namespace XamlIcons.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IconModel> _icons = new ObservableCollection<IconModel>();
        private IconModel _selectedIcon;

        public MainWindowViewModel()
        {
            
        }

        public ObservableCollection<IconModel> Icons
        {
            get { return _icons; }
            set { _icons = value; }
        }

        public IconModel SelectedIcon
        {
            get { return _selectedIcon; }
            set
            {
                _selectedIcon = value;
                OnPropertyChanged();
            }
        }
    }
}
