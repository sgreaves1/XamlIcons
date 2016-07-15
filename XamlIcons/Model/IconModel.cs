namespace XamlIcons.Model
{
    public class IconModel : BaseModel
    {
        private string _author;
        private string _location;
        private string _name;
        private string _data;
        private bool _isSelected;

        public IconModel (string author, string location, string name, string data)
        {
            Author = author;
            Location = location;
            Name = name;
            Data = data;
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }

        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged();
            }
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

        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }
    }
}
