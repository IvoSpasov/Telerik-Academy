﻿namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    public class Chair : Furniture, IChair
    {
        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get;
            private set;
        }
    }
}