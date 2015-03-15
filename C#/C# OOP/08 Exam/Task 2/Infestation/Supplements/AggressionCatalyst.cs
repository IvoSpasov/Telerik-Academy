namespace Infestation.Supplements
{
    public class AggressionCatalyst : Supplement
    {
        private const int Aggression = 3;

        public AggressionCatalyst()
            : base(Supplement.Zero, Supplement.Zero, Aggression)
        {
        }
    }
}
