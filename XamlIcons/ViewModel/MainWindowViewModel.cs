﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using XamlIcons.Commands;
using XamlIcons.Model;

namespace XamlIcons.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IconModel> _icons = new ObservableCollection<IconModel>();
        private IconModel _selectedIcon;
        private int _selectedIndex;
        

        public MainWindowViewModel()
        {
            GetIcons();

            _selectedIndex = 0;

            GetSelectedIcon();

            InitCommands();
        }

        private void GetIcons()
        {
            Icons.Add(new IconModel("Running Man", "M297.290,51.396 C262.000,50.999 246.954,83.495 261.290,124.396 L258.5,132.5 229,124 162,145.5 C152.854,152.268 150.539,159.446 154.5,167 L174,223 C185.691,236.661 193.877,234.414 198.5,216 L182,168.5 224,154.5 228.5,170.5 220,226 167.5,279.5 114,254.5 96.5,256 75.5,292.5 C78.181,308.041 85.564,312.972 98,306.5 L112,281.5 156,304 C165.007,311.500 172.673,311.331 179,303.5 L213,268.5 230.5,263.5 255,269 311,297 304,340.5 C301.959,349.296 303.918,355.654 310,359.5 L336,376.5 C352.586,380.964 356.915,374.496 350,358 L332,343.5 337,297 C338.268,286.908 333.850,279.974 325,275.5 L277.5,250 295.5,191 303.5,200 316.5,234.5 C323.303,246.152 331.801,248.497 342,241.5 L390,206 C397.694,190.695 392.958,184.365 376.5,186.5 L337,213 318.5,167 310.5,157.5 287.5,146.5 286,135 C333.000,124.000 333.500,68.499 297.290,51.396 z"));
            Icons.Add(new IconModel("Swap horiz", "F1 M24,24z M0,0z M6.99,11L3,15 6.99,19 6.99,16 14,16 14,14 6.99,14 6.99,11z M21,9L17.01,5 17.01,8 10,8 10,10 17.01,10 17.01,13 21,9z"));
            Icons.Add(new IconModel("Forward 5", "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.5,15.9 12.3,16 12.1,16 11.9,16 11.7,16 11.5,16 11.4,15.9 11.3,15.8 11.1,15.8 10.9,15.7 10.7,15.6 10.7,15.5 10.6,15.3 10.5,15.1 10.5,15 10.5,14.8L11.3,14.8C11.3,15 11.4,15.1 11.5,15.2 11.6,15.3 11.7,15.3 11.9,15.3 12,15.3 12.1,15.3 12.2,15.2L12.4,15C12.4,15,12.5,14.8,12.5,14.7L12.5,14.1 12.4,13.9 12.2,13.7C12.2,13.7,12,13.6,11.9,13.6L11.7,13.6C11.7,13.6 11.6,13.6 11.5,13.7 11.4,13.8 11.4,13.7 11.4,13.8 11.4,13.9 11.3,13.9 11.3,13.9L10.7,13.9z"));
        }

        private void GetSelectedIcon()
        {
            SelectedIcon = Icons[_selectedIndex];
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

        public ICommand BackCommand { get; private set; }
        public ICommand NextCommand { get; private set; }

        public void InitCommands()
        {
            BackCommand = new RelayCommand(ExecuteBackPageCommand, CanExecuteBackPageCommand);
            NextCommand = new RelayCommand(ExecuteNextPageCommand, CanExecuteNextPageCommand);
        }

        public bool CanExecuteBackPageCommand()
        {
            return true;
        }

        public void ExecuteBackPageCommand()
        {
            _selectedIndex--;

            if (_selectedIndex <= 0)
                _selectedIndex = Icons.Count-1;

            GetSelectedIcon();
        }

        public bool CanExecuteNextPageCommand()
        {
            return true;
        }

        public void ExecuteNextPageCommand()
        {
            _selectedIndex++;

            if (_selectedIndex > Icons.Count - 1)
                _selectedIndex = 0;

            GetSelectedIcon();
        }
    }
}
