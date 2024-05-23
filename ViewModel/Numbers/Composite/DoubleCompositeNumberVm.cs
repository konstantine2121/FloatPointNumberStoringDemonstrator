using FloatPointNumberStoringDemonstrator.Model.Numbers;
using FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Composite
{
    internal class DoubleCompositeNumberVm : CompositeNumberVm
    {
        private readonly BaseNumber<double> _doubleNumber;

        public DoubleCompositeNumberVm(BaseNumber<double> doubleNumber) 
        {
            _doubleNumber = doubleNumber;

            HexadecimalVm = new HexadecimalNumberVm<double>(doubleNumber);
            DecimalVm = new NumberVm<double>(doubleNumber);
            BinaryVm = new BinaryNumberVm<double>(doubleNumber);
        }

        public override NumberVm BinaryVm { get; }

        public override NumberVm HexadecimalVm { get; }

        public override NumberVm DecimalVm { get; }
    }
}
