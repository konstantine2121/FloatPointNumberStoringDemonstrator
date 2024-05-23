using System;

namespace NumericStoringDemonstration.Model.Numbers
{
    internal abstract class BaseNumber<T>
    {
        private const int BitsPerByte = 8;


        #region Fields

        private T _value = default;

        #endregion Fields

        #region Ctors

        protected BaseNumber() { }

        protected BaseNumber(T value)
        {
            _value = value;
        }

        #endregion Ctors

        #region Events

        public EventHandler ValueChanged;

        #endregion Events

        #region Properties

        /// <summary>
        /// Значение
        /// </summary>
        public T Value
        {
            get => _value;
            set 
            { 
                _value = value; 
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Знак = 0 или 1
        /// </summary>
        public byte Sign => GetSign();

        /// <summary>
        /// Значение порядка
        /// </summary>
        public ulong Exponent => GetExponent();

        /// <summary>
        /// Значение мантиссы
        /// </summary>
        public ulong Fraction => GetFraction();

        /// <summary>
        /// Длина порядка в битах
        /// </summary>
        public abstract byte ExponentLength { get; }

        /// <summary>
        ///  Длина мантиссы в битах
        /// </summary>
        public abstract byte FractionLength { get; }

        #endregion Properties

        #region Abstract Methods

        private byte GetSign()
        {
            return (byte)ExtractValue(1, (byte)(ExponentLength + FractionLength));
        }

        private ulong GetExponent()
        {
            return ExtractValue(ExponentLength, FractionLength);
        }

        private ulong GetFraction()
        {
            return ExtractValue(FractionLength, 0);
        }

        #endregion Abstract Methods

        #region Methods

        protected ulong ExtractValue(byte maskLengthInBits, byte leftOffset)
        {
            var value = GetValue();
            var mask = CreateMask(maskLengthInBits) << leftOffset;
            var maskedValue = (value | mask) >> leftOffset;

            return maskedValue;
        }

        private ulong GetValue()
        {
            var bytes = Value.GetBytes();
            return BitConverter.ToUInt64(bytes, 0);
        }

        private ulong CreateMask(byte lengthInBits)
        {
            int maskSize = sizeof(ulong) * BitsPerByte;
            ulong mask = 0;
            
            for (int shift = 0; shift < lengthInBits && shift < maskSize; shift++)
            {
                mask |= (1UL << shift);
            }

            return mask;
        }

        #endregion

    }
}
