namespace XamlIcons.Model
{
    public class IconModel : BaseModel
    {
        private string _name;
        private string _data;

        public IconModel (string name, string data)
        {
            Name = name;
            Data = data;
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
    }
}
