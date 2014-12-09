// Refactor the following class using best practices for organizing straight-line code:

namespace _01_StraightLineCode
{
    using System;
    
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Peel(potato);
            Peel(carrot);
            Cut(potato);
            Cut(carrot);
            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private void Cut(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
    }
}