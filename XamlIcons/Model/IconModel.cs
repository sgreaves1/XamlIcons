namespace XamlIcons.Model
{
    public class IconModel : BaseModel
    {
        private string _name;
        private string _data;

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
