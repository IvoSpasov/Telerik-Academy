namespace ComputerParts.Interfaces
{
    public interface IBattery
    {        
        int BatteryPercentage { get; }

        void Charge(int additialCharge);
    }
}
