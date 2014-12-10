namespace ToysStore.SampleDataGenerator.DataGenerators
{
    using System;
    using System.Collections.Generic;

    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal class ManufacturerDataGenerator : DataGenerator, IDataGenerator
    {
        public ManufacturerDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreDatabase, int countOfGeneratedObjects)
            : base(randomDataGenerator, toysStoreDatabase, countOfGeneratedObjects)
        {
        }

        public override void Generate()
        {
            var manufacturersNamesToBeAdded = new HashSet<string>();

            while (manufacturersNamesToBeAdded.Count != this.Count)
            {
                manufacturersNamesToBeAdded.Add(this.Random.GetRandomStringWithRandomLenght(0, 20));
            }

            int index = 1;
            Console.WriteLine("Adding manufacturers");
            foreach (var name in manufacturersNamesToBeAdded)
            {
                var currentManufacturer = new Manufacturer
                {
                    Name = name,
                    Country = this.Random.GetRandomStringWithRandomLenght(2, 50)
                };

                this.Database.Manufacturers.Add(currentManufacturer);
                index++;

                if (index % 100 == 0)
                {
                    Console.Write(".");
                    this.Database.SaveChanges();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Manufacturers added");
        }
    }
}
