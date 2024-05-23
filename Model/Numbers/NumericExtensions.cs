using System;

namespace FloatPointNumberStoringDemonstrator.Model.Numbers
{
    internal static class NumericExtensions
    {
        public static byte[] GetBytes(this double value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] GetBytes(this float value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] GetBytes(this object value)
        {
            if (value is double d)
                return GetBytes(d);

            if (value is float f)
                return GetBytes(f);

            throw new NotSupportedException();
        }


    }
}
