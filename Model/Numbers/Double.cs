using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericStoringDemonstration.Model.Numbers
{
    internal class Double : BaseNumber<double>
    {
        public override byte ExponentLength => 11;

        public override byte FractionLength => 52;
    }
}
