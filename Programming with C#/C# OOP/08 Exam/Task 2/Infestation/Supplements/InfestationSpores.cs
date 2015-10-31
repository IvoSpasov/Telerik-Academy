namespace Infestation.Supplements
{
    public class InfestationSpores : Supplement
    {
        private const int Agression = 20;
        private const int Power = -1;

        public InfestationSpores()
            : base(Power, 0, Agression)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.AggressionEffect = 0;
                this.PowerEffect = 0;
            }
        }
    }
}
