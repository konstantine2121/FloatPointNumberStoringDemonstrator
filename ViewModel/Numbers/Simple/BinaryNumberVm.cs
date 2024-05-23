using FloatPointNumberStoringDemonstrator.Model.Numbers;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple
{
    internal class BinaryNumberVm<T> : NumberVm<T> where T : struct
    {
        private const string BinaryFormat = "B";

        public BinaryNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => number.Exponent.ToString(BinaryFormat + ExponentLength);

        public override string Fraction => number.Fraction.ToString(BinaryFormat + FractionLength);
    }
}
