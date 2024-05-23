namespace FloatPointNumberStoringDemonstrator.Model.Numbers
{
    internal class Single : BaseNumber<float>
    {
        public override byte ExponentLength => 8;

        public override byte FractionLength => 23;
    }
}
