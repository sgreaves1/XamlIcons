using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using XamlIcons.Model;

namespace XamlIcons.UserControl
{
    /// <summary>
    /// Interaction logic for GalleryDisplay.xaml
    /// </summary>
    public partial class GalleryDisplay 
    {
        /// <summary>
        /// Dependency Property for the Icons 
        /// </summary>
        public static readonly DependencyProperty IconsProperty =
            DependencyProperty.Register("Icons",
                typeof(IEnumerable<IconModel>),
                typeof(GalleryDisplay),
                new PropertyMetadata(null));

        /// <summary>
        /// Dependency Property for the Icon 
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("SelectedIcon",
                typeof(IconModel),
                typeof(GalleryDisplay),
                new PropertyMetadata(null));

        /// <summary>
        /// Dependency Property for the Icon 
        /// </summary>
        public static readonly DependencyProperty IconSelectedCommandProperty =
            DependencyProperty.Register("IconSelectedCommand",
                typeof(ICommand),
                typeof(GalleryDisplay),
                new PropertyMetadata(null));

        /// <summary>
        /// Constructor
        /// </summary>
        public GalleryDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The icons this gallery will be based on
        /// </summary>
        public IEnumerable<IconModel> Icons
        {
            get { return (IEnumerable<IconModel>)GetValue(IconsProperty); }
            set { SetValue(IconsProperty, value); }
        }

        /// <summary>
        /// The selected Icon
        /// </summary>
        public IconModel SelectedIcon
        {
            get { return (IconModel)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public ICommand IconSelectedCommand
        {
            get { return (ICommand)GetValue(IconSelectedCommandProperty); }
            set { SetValue(IconSelectedCommandProperty, value); }
        }
    }
}
