namespace FloatPointNumberStoringDemonstrator.Model.Numbers
{
    internal class Double : BaseNumber<double>
    {
        public override byte ExponentLength => 11;

        public override byte FractionLength => 52;
    }
}
