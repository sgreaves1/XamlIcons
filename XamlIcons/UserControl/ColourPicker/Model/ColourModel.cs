using XamlIcons.Model;

namespace XamlIcons.UserControl.ColourPicker.Model
{
    public class ColourModel : BaseModel
    {
        private string _name;

        public ColourModel(string name)
        {
            Name = name;
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
    }
}
