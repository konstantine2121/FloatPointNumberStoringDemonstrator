using FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Composite
{
    internal abstract class CompositeNumberVm
    {
        public abstract NumberVm BinaryVm { get; }

        public abstract NumberVm DecimalVm { get; }

        public abstract NumberVm BytesVm { get; }
    }
}
