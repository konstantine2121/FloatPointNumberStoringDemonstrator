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

            Model.Numbers.Double model = new Model.Numbers.Double();
            model.Value = 5;

            var vm = new ViewModel.Numbers.BinaryNumberVm<double>(model);

            value.DataContext = vm;
        }
    }
}