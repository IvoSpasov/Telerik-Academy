namespace ComputerParts.Interfaces
{
    public interface IBattery
    {        
        int BatterPercentage { get; }

        void Charge(int additialCharge);
    }
}
