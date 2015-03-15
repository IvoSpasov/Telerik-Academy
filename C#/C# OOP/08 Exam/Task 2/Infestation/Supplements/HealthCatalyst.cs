﻿namespace Infestation.Supplements
{
    public class HealthCatalyst : Supplement
    {
        private const int HealthEffect = 3;
        private const int Zero = 0;

        public HealthCatalyst()
            : base(Zero, HealthEffect, Zero)
        {
        }
    }
}