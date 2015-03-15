using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class PowerCatalyst : Supplement
    {
        private const int PowerEffect = 3;
        private const int Zero = 0;

        public PowerCatalyst()
            : base(PowerEffect, Zero, Zero)
        {
        }
    }
}
