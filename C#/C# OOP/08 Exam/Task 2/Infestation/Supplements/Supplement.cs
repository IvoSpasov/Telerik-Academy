namespace Infestation.Supplements
{
    public abstract class Supplement : ISupplement
    {
        protected const int Zero = 0;

        public Supplement(int power, int health, int aggression)
        {
            this.PowerEffect = power;
            this.HealthEffect = health;
            this.AggressionEffect = aggression;
        }

        public int PowerEffect
        {
            get;
            protected set;
        }

        public int HealthEffect
        {
            get;
            protected set;
        }

        public int AggressionEffect
        {
            get;
            protected set;
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            // Just leave it empty and override it where needed (Weapon class)? Really?
            // If I make it abstract I will have to create an empty method in the other children.
        }
    }
}
