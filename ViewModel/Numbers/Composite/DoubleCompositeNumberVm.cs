using FloatPointNumberStoringDemonstrator.Model.Numbers;
using FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Composite
{
    internal class DoubleCompositeNumberVm : CompositeNumberVm
    {
        public DoubleCompositeNumberVm(BaseNumber<double> number) 
        {
            DecimalVm = new NumberVm<double>(number);
            BinaryVm = new BinaryNumberVm<double>(number);
            BytesVm = new BytesNumberVm<double>(number);
        }

        public override NumberVm BinaryVm { get; }

        public override NumberVm DecimalVm { get; }

        public override NumberVm BytesVm { get; }
    }
}
