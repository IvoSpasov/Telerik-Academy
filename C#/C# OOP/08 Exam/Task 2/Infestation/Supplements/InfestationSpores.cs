namespace Infestation.Supplements
{
    public class InfestationSpores : Supplement
    {
        private const int Agression = 20;
        private const int Power = -1;

        public InfestationSpores()
            : base(Power, Supplement.Zero, Agression)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.AggressionEffect = Supplement.Zero;
                this.HealthEffect = Supplement.Zero;
                this.PowerEffect = Supplement.Zero;
            }
        }
    }
}
