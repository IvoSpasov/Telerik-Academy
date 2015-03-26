namespace Computers.Common.Factories
{
    using System;

    public class DellComputers : IComputerFactory
    {
        public Pc CreatePc()
        {
            throw new NotImplementedException();
        }

        public Server CreateServer()
        {
            throw new NotImplementedException();
        }

        public Laptop CreateLaptop()
        {
            throw new NotImplementedException();
        }
    }
}
