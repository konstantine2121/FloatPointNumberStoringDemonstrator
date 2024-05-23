using FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Composite
{
    internal abstract class CompositeNumberVm
    {
        public abstract NumberVm BinaryVm { get; }

        public abstract NumberVm HexadecimalVm { get; }

        public abstract NumberVm DecimalVm { get; }
    }
}
