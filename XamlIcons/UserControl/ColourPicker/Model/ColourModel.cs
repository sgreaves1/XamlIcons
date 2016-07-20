using System.Windows.Media;
using XamlIcons.Model;

namespace XamlIcons.UserControl.ColourPicker.Model
{
    public class ColourModel : BaseModel
    {
        private string _name;
        private Color _colour;

        public ColourModel(string name, Color colour)
        {
            Name = name;
            Colour = colour;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public Color Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
                OnPropertyChanged();
            }
        }
    }
}
