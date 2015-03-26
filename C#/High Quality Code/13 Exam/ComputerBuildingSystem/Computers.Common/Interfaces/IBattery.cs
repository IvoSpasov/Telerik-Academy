namespace Computers.Common.Interfaces
{
    public interface IBattery
    {        
        int BatteryPercentage { get; }

        void Charge(int additialCharge);
    }
}
