using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly ViewModel _viewModel;

        public MainWindow(ViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            // Uncomment it to see now is OnIsActivatedPropertyChangedCallback, GetBinding() on TextBox.TextProperty will return correct data!!!?
            //MyTextBox.SetValue(ChangeBehavior.IsActivatedProperty, false);
        }
    }
}
