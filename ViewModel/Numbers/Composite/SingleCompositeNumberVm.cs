using FloatPointNumberStoringDemonstrator.Model.Numbers;
using FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Composite
{
    internal class SingleCompositeNumberVm : CompositeNumberVm
    {
        public SingleCompositeNumberVm(BaseNumber<float> number)
        {
            DecimalVm = new NumberVm<float>(number);
            BinaryVm = new BinaryNumberVm<float>(number);
            BytesVm = new BytesNumberVm<float>(number);
        }

        public override NumberVm BinaryVm { get; }

        public override NumberVm DecimalVm { get; }

        public override NumberVm BytesVm { get; }
    }
}
