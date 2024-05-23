using System.Windows;

namespace FloatPointNumberStoringDemonstrator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeModel();         
        }

        private void InitializeModel()
        {
            var model = new Model.Numbers.Single();
            var vm = new ViewModel.Numbers.Composite.SingleCompositeNumberVm(model);
            singleView.DataContext = vm;
        }
    }
}