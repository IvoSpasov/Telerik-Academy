namespace Infestation.Supplements
{
    public class HealthCatalyst : Supplement
    {
        private const int Health = 3;

        public HealthCatalyst()
            : base(Supplement.Zero, Health, Supplement.Zero)
        {
        }
    }
}
