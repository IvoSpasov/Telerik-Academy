namespace ToysStore.SampleDataGenerator.DataGenerators
{
    using System;

    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal class AgeRangeDataGenerator : DataGenerator, IDataGenerator
    {
        public AgeRangeDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreDatabase, int countOfGeneratedObjects)
            : base(randomDataGenerator, toysStoreDatabase, countOfGeneratedObjects)
        {
        }

        public override void Generate()
        {
            Console.WriteLine("Adding age ranges");
            int count = 0;
            for (int i = 0; i < this.Count / 5; i++)
            {
                for (int j = i + 1; j < i + 5; j++)
                {
                    var currentAgeRange = new AgeRanx
                    {
                        MinAge = i,
                        MaxAge = j
                    };

                    this.Database.AgeRanges.Add(currentAgeRange);
                    count++;

                    if (count % 100 == 0)
                    {
                        this.Database.SaveChanges();
                        Console.Write(".");
                    }

                    if (count == this.Count)
                    {
                        return;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Age ranges added ");
        }
    }
}
