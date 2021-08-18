namespace Carnac.UI
{
    public partial class PreferencesView
    {
        public PreferencesView(PreferencesViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }

		private void PositionOnMonitorSelector_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{

		}
	}
}