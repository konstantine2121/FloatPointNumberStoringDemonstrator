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

        public static byte[] GetBytes(this ulong value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] GetBytes(this long value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] GetBytes(this object value)
        {
            if (value is double d)
                return GetBytes(d);

            if (value is float f)
                return GetBytes(f);

            if (value is long l)
                return GetBytes(l);

            if (value is ulong ul)
                return GetBytes(ul);

            throw new NotSupportedException();
        }

        public static T Cast<T>(this object value)
        {
            if (typeof(T) == value.GetType())
                return (T)value;

            if (typeof(T) == typeof(float) && value is double dv)
                return (T)(object)(float)dv;                

            throw new NotSupportedException();
        }
    }
}
