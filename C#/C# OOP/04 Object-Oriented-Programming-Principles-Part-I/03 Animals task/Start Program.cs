namespace _03_Animals_task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<Animals> listOfFrogs = new List<Animals>()
            {
                new Frog("Mortisha", 5, false),
                new Frog("Webby", 8, true),
                new Frog("Hoppity", 1, true),
                new Frog("Flibbit", 3, true),
                new Frog("Eden", 4, false),
            };
                
            Console.WriteLine("The average age of our frogs is: " + Frog.CalculateAverageAge(listOfFrogs));
            listOfFrogs[0].MakeSound();

            var listOfDogs = new List<Animals>()
            {
                new Dog("Max", 3, true),
                new Dog("Lucy", 2, false),
                new Dog("Lady", 4, false),
                new Dog("Casey", 3, false),
                new Dog("Baxter", 7, true),
            };

            Console.WriteLine("The average age of our dogs is: " + Animals.CalculateAverageAge(listOfDogs));
            listOfDogs[0].MakeSound();

            var listOfKittens = new List<Animals>()
            {
                new Kitten("Pepsi", 0.1),
                new Kitten("Ellie", 0.1),
                new Kitten("Amber", 0.2),
                new Kitten("Milkshake", 0.3),
                new Kitten("Buttons", 0.5),
            };

            Console.WriteLine("The average age of our kittens is: " + Animals.CalculateAverageAge(listOfKittens));
            listOfKittens[0].MakeSound();

            var listOfTomCats = new List<Animals>()
            {
                new TomCat("Mittens", 4),
                new TomCat("Charlie", 3),
                new TomCat("Smokey", 5),
                new TomCat("Skittles", 4),
                new TomCat("Nioo", 9),
            };

            Console.WriteLine("The average age of our tom cats is: " + Animals.CalculateAverageAge(listOfTomCats));
            listOfTomCats[0].MakeSound();
        }
    }
}
