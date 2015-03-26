namespace Computers.Common.Factories
{
    public interface IComputerFactory
    {
        Computer CreatePc();

        Computer CreateServer();

        Computer CreateLaptop();
    }
}
