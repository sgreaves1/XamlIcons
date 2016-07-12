using System.Windows;
using XamlIcons.Model;

namespace XamlIcons.UserControl
{
    /// <summary>
    /// Interaction logic for IconInfoDisplay.xaml
    /// </summary>
    public partial class IconInfoDisplay 
    {
        /// <summary>
        /// Dependency Property for the Icon 
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",
                typeof(IconModel), 
                typeof(IconInfoDisplay), 
                new PropertyMetadata(null));

        /// <summary>
        /// Constructor
        /// </summary>
        public IconInfoDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The icon this display will be based on
        /// </summary>
        public IconModel Icon
        {
            get { return (IconModel)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }
}
