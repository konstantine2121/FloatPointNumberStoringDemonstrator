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
                .ToList();
            RemoveEmptyBytes(bytes);

            return String.Join(" ", bytes.Select(b => b.ToString(ByteFormat + 2)));
        }

        private static void RemoveEmptyBytes(List<byte> bytes)
        {
            for (int i = 0; i < bytes.Count-1;)
            {
                if (bytes[i] == 0)
                {
                    bytes.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
