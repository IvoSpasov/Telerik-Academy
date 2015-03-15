namespace Infestation.Supplements
{
    public class PowerCatalyst : Supplement
    {
        private const int Power = 3;

        public PowerCatalyst()
            : base(Power, Supplement.Zero, Supplement.Zero)
        {
        }
    }
}
