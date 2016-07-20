using System.Windows;

namespace XamlIcons.UserControl.ColourPicker
{
    /// <summary>
    /// Interaction logic for ColourPicker.xaml
    /// </summary>
    public partial class ColourPicker
    {
        /// <summary>
        /// Dependency Property for the <see cref="Data"/> property
        /// </summary>
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data",
                typeof(string),
                typeof(ColourPicker),
                new PropertyMetadata(""));

        /// <summary>
        /// Dependency Property for the <see cref="ButtonWidth"/> property
        /// </summary>
        public static readonly DependencyProperty ButtonWidthProperty =
            DependencyProperty.Register("ButtonWidth",
                typeof(double),
                typeof(ColourPicker),
                new PropertyMetadata(0.0));

        /// <summary>
        /// Dependency Property for the <see cref="ButtonHeight"/> property
        /// </summary>
        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register("ButtonHeight",
                typeof(double),
                typeof(ColourPicker),
                new PropertyMetadata(0.0));

        /// <summary>
        /// Dependency Property for the <see cref="IconWidth"/> property
        /// </summary>
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth",
                typeof(double),
                typeof(ColourPicker),
                new PropertyMetadata(0.0));

        /// <summary>
        /// Dependency Property for the <see cref="IconHeight"/> property
        /// </summary>
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight",
                typeof(double),
                typeof(ColourPicker),
                new PropertyMetadata(0.0));

        /// <summary>
        /// Dependency Property for the <see cref="ColoursVisible"/> property
        /// </summary>
        public static readonly DependencyProperty ColoursVisibleProperty =
            DependencyProperty.Register("ColoursVisible",
                typeof(bool),
                typeof(ColourPicker),
                new PropertyMetadata(false));

        public ColourPicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The geometry data of the button
        /// </summary>
        public string Data
        {
            get { return (string)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        /// <summary>
        /// The width of the button
        /// </summary>
        public double ButtonWidth
        {
            get { return (double)GetValue(ButtonWidthProperty); }
            set { SetValue(ButtonWidthProperty, value); }
        }

        /// <summary>
        /// The width of the button
        /// </summary>
        public double ButtonHeight
        {
            get { return (double)GetValue(ButtonHeightProperty); }
            set { SetValue(ButtonHeightProperty, value); }
        }

        /// <summary>
        /// The width of the icon
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        /// <summary>
        /// The height of the icon
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        public bool ColoursVisible
        {
            get { return (bool)GetValue(ColoursVisibleProperty); }
            set { SetValue(ColoursVisibleProperty, value); }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ColoursVisible = !ColoursVisible;
        }

        private void ToggleButton1_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
