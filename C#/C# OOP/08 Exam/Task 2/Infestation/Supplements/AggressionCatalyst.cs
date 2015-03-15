namespace Infestation.Supplements
{
    public class AggressionCatalyst : Supplement
    {
        private const int AggressionEffect = 3;
        private const int Zero = 0;

        public AggressionCatalyst()
            : base(Zero, Zero, AggressionEffect)
        {
        }
    }
}
