namespace NamingIdentifiers.Task4.Interfaces
{
    using System;

    public interface IPlayer
    {
        string Name { get; }

        int Points { get; set; }
    }
}