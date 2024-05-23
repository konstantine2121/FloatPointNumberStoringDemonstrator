using System.Runtime.Serialization.Formatters.Binary;
using NumericStoringDemonstration.Model.Numbers;

namespace NumericStoringDemonstration.ViewModel.Numbers
{
    internal class BinaryNumberVm<T> : NumberVm<T>
    {
        private const string BinaryFormat = "B";

        public BinaryNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => number.Exponent.ToString(BinaryFormat);

        public override string Fraction => number.Fraction.ToString(BinaryFormat);
    }
}
