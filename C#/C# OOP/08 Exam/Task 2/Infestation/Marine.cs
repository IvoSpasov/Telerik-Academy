namespace Infestation
{
    using Infestation.Supplements;

    public class Marine : Human
    {
        public Marine(string id)
            : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }
    }
}
