﻿using FloatPointNumberStoringDemonstrator.Model.Numbers;

namespace FloatPointNumberStoringDemonstrator.ViewModel.Numbers.Simple
{
    internal class HexadecimalNumberVm<T> : NumberVm<T> where T : struct
    {
        private const string HexFormat = "X";

        public HexadecimalNumberVm(BaseNumber<T> number) : base(number)
        {
        }

        public override string Exponent => number.Exponent.ToString(HexFormat);

        public override string Fraction => number.Fraction.ToString(HexFormat);
    }
}
