using NumericStoringDemonstration.Model.Numbers;

namespace NumericStoringDemonstration.ViewModel.Numbers
{
    internal class HexadecimalNumberVm<T> : NumberVm<T>
    {
        private const string HexFormat = "X";

        public HexadecimalNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => number.Exponent.ToString(HexFormat);

        public override string Fraction => number.Fraction.ToString(HexFormat);
    }
}
