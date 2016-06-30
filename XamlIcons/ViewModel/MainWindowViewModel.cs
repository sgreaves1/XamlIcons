using System.Collections.ObjectModel;
using System.Linq;
using XamlIcons.Model;

namespace XamlIcons.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IconModel> _icons = new ObservableCollection<IconModel>();
        private IconModel _selectedIcon;

        public MainWindowViewModel()
        {
            GetIcons();
        }

        private void GetIcons()
        {
            Icons.Add(new IconModel("Running Man", "M297.290,51.396 C262.000,50.999 246.954,83.495 261.290,124.396 L258.5,132.5 229,124 162,145.5 C152.854,152.268 150.539,159.446 154.5,167 L174,223 C185.691,236.661 193.877,234.414 198.5,216 L182,168.5 224,154.5 228.5,170.5 220,226 167.5,279.5 114,254.5 96.5,256 75.5,292.5 C78.181,308.041 85.564,312.972 98,306.5 L112,281.5 156,304 C165.007,311.500 172.673,311.331 179,303.5 L213,268.5 230.5,263.5 255,269 311,297 304,340.5 C301.959,349.296 303.918,355.654 310,359.5 L336,376.5 C352.586,380.964 356.915,374.496 350,358 L332,343.5 337,297 C338.268,286.908 333.850,279.974 325,275.5 L277.5,250 295.5,191 303.5,200 316.5,234.5 C323.303,246.152 331.801,248.497 342,241.5 L390,206 C397.694,190.695 392.958,184.365 376.5,186.5 L337,213 318.5,167 310.5,157.5 287.5,146.5 286,135 C333.000,124.000 333.500,68.499 297.290,51.396 z"));
            Icons.Add(new IconModel("Swap horiz", "F1 M24,24z M0,0z M6.99,11L3,15 6.99,19 6.99,16 14,16 14,14 6.99,14 6.99,11z M21,9L17.01,5 17.01,8 10,8 10,10 17.01,10 17.01,13 21,9z"));

            SelectedIcon = Icons.First();
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
