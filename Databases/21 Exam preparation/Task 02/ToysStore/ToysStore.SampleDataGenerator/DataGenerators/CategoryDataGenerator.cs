namespace ToysStore.SampleDataGenerator.DataGenerators
{
    using System;

    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal class CategoryDataGenerator : DataGenerator, IDataGenerator
    {

        public CategoryDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreDatabase, int countOfGeneratedObjects)
            : base(randomDataGenerator, toysStoreDatabase, countOfGeneratedObjects)
        {
        }

        public override void Generate()
        {
            Console.WriteLine("Adding categories");

            for (int i = 0; i < this.Count; i++)
            {
                var currentCategory = new Category
                {
                    Name = this.Random.GetRandomStringWithRandomLenght(5, 50),
                };

                this.Database.Categories.Add(currentCategory);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Database.SaveChanges();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Categories added");
        }
    }
}
