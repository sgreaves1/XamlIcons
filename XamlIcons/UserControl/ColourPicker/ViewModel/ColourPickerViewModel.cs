using System.Collections.ObjectModel;
using System.Windows.Media;
using XamlIcons.UserControl.ColourPicker.Model;
using XamlIcons.ViewModel;

namespace XamlIcons.UserControl.ColourPicker.ViewModel
{
    public class ColourPickerViewModel : BaseViewModel
    {
        private ObservableCollection<ColourModel> _colours = new ObservableCollection<ColourModel>();

        public ColourPickerViewModel()
        {
            GetColours();
        }

        private void GetColours()
        {
            Colours.Add(new ColourModel("Alice Blue", Colors.AliceBlue));
            Colours.Add(new ColourModel("Antique White", Colors.AntiqueWhite));
        }

        public ObservableCollection<ColourModel> Colours
        {
            get { return _colours; }
            set
            {
                _colours = value;
                OnPropertyChanged();
            }
        }  
    }
}
