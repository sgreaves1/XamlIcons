using System.Windows;
using System.Windows.Input;
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
        /// Dependency Property for the Copy to clipboard command 
        /// </summary>
        public static readonly DependencyProperty CopyToClipBoardCommandProperty =
            DependencyProperty.Register("CopyToClipBoardCommand",
                typeof(ICommand),
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

        /// <summary>
        /// Command to copy data to the clip board
        /// </summary>
        public ICommand CopyToClipBoardCommand
        {
            get { return (ICommand)GetValue(CopyToClipBoardCommandProperty); }
            set { SetValue(CopyToClipBoardCommandProperty, value); }
        }
    }
}
