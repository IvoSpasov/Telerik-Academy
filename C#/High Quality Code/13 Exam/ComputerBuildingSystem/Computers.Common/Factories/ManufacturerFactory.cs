namespace Computers.Common.Factories
{
    using System;

    using Computers.Common.Enums;

    public static class ManufacturerFactory
    {
        public static IComputerFactory GetFactory(Manufacturer manufacturer)
        {
            switch (manufacturer)
            {
                case Manufacturer.Dell:
                    return new DellComputers();
                case Manufacturer.Hp:
                    return new HpComputers();
                default:
                    throw new ArgumentException("There is no such manufacturer " + manufacturer.ToString());
            }
        }
    }
}
