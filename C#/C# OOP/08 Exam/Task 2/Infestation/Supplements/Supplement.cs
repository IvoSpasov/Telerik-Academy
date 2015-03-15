namespace Infestation.Supplements
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

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            // what should be inside?

            //this.PowerEffect += otherSupplement.PowerEffect;
            //this.HealthEffect += otherSupplement.HealthEffect;
            //this.AggressionEffect += otherSupplement.AggressionEffect;
        }
    }
}
