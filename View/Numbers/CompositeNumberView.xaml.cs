using System.Windows.Controls;

namespace FloatPointNumberStoringDemonstrator.View.Numbers
{
    /// <summary>
    /// Логика взаимодействия для CompositeNumberView.xaml
    /// </summary>
    public partial class CompositeNumberView : UserControl
    {
        public CompositeNumberView()
        {
            InitializeComponent();
            InitializeModel();
        }

        private void InitializeModel()
        {
            var model = new Model.Numbers.Double();
            var vm = new ViewModel.Numbers.Composite.DoubleCompositeNumberVm(model);
            DataContext = vm;
        }
    }
}
