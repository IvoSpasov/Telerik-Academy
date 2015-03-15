using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        public Supplement(int power, int health, int aggression)
        {
            this.PowerEffect = power;
            this.HealthEffect = health;
            this.AggressionEffect = aggression;
        }

        public int PowerEffect
        {
            get;
            private set;
        }

        public int HealthEffect
        {
            get;
            private set;
        }

        public int AggressionEffect
        {
            get;
            private set;
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            this.PowerEffect += otherSupplement.PowerEffect;
            this.HealthEffect += otherSupplement.HealthEffect;
            this.AggressionEffect += otherSupplement.AggressionEffect;
        }
    }
}
