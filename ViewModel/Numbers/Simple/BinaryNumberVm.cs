using System.Text;
using FloatPointNumberStoringDemonstrator.Model.Numbers;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple
{
    internal class BinaryNumberVm<T> : NumberVm<T> where T : struct
    {
        private const string BinaryFormat = "B";
        private const int BitsPerByte = 8;

        public BinaryNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => AddSpaces(number.Exponent.ToString(BinaryFormat + ExponentLength));

        public override string Fraction => AddSpaces(number.Fraction.ToString(BinaryFormat + FractionLength));

        private string AddSpaces(string value)
        {
            var separator = " ";
            var sb = new StringBuilder(value);

            for (var i = sb.Length - BitsPerByte; i > 0; i -= BitsPerByte)
            {
                sb.Insert(i, separator);
            }

            return sb.ToString();
        }
    }
}
