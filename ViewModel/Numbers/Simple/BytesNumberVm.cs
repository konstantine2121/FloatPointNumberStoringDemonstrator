using System.Text;
using FloatPointNumberStoringDemonstrator.Model.Numbers;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple
{
    internal class BytesNumberVm<T> : NumberVm<T> where T : struct
    {
        private const string ByteFormat = "X";

        public BytesNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => GetBytesString(number.Exponent);

        public override string Fraction => GetBytesString(number.Fraction);


        private string GetBytesString(ulong value)
        {
            var bytes = value.GetBytes()
                .Reverse()
                .Select(b => b.ToString(ByteFormat + 2));

            return String.Join(" ", bytes);
        }
    }
}
