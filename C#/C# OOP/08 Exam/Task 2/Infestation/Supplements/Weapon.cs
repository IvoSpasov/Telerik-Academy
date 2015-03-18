namespace Infestation.Supplements
{
    public class Weapon : Supplement
    {
        private const int Power = 10;
        private const int Aggression = 3;

        public Weapon()
            : base(0, 0, 0)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = Power;
                this.AggressionEffect = Aggression;
            }
        }
    }
}
