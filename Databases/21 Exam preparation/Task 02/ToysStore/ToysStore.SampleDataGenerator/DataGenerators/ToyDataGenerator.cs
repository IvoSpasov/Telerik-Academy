namespace ToysStore.SampleDataGenerator.DataGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal class ToyDataGenerator : DataGenerator, IDataGenerator
    {
        public ToyDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreDatabase, int countOfGeneratedObjects)
            : base(randomDataGenerator, toysStoreDatabase, countOfGeneratedObjects)
        {
        }

        public override void Generate()
        {
            var ageRangeIds = this.Database.AgeRanges
                .Select(a => a.Id)
                .ToList();

            var manufacturerIds = this.Database.Manufacturers
                .Select(m => m.Id)
                .ToList();

            var categoryIds = this.Database.Categories
                .Select(c => c.Id)
                .ToList();

            Console.WriteLine("Adding toys");
            for (int i = 0; i < this.Count; i++)
            {
                var currentToy = new Toy
                {
                    Name = this.Random.GetRandomStringWithRandomLenght(5, 20),
                    Type = this.Random.GetRandomStringWithRandomLenght(5, 20),
                    Price = this.Random.GetRandomNumber(50, 500),
                    // 99% ot cenite sa pod 100 dolara... ili na vsqko stotno ili gen ran number ot 1 do 100.. padne li se 100
                    // 99% kum 1% e null -> getRandomNumber(1, 100) == 100 ? null : 
                    // 65% : 35% random num ot 1 do 100 i ako 4isloto e < 65 ili > 65
                    Color = this.Random.GetRandomNumber(1, 5) == 5 ? null : this.Random.GetRandomStringWithRandomLenght(5, 20),
                    ManufacturerId = manufacturerIds[this.Random.GetRandomNumber(0, manufacturerIds.Count - 1)],
                    AgeRangeId = ageRangeIds[this.Random.GetRandomNumber(0, ageRangeIds.Count - 1)]
                };


                if (categoryIds.Count > 0)
                {
                    var uniqueCategoryIds = new HashSet<int>();
                    var categoriesInToy = this.Random.GetRandomNumber(1, Math.Min(10, categoryIds.Count));

                    while (uniqueCategoryIds.Count != categoriesInToy)
                    {
                        uniqueCategoryIds.Add(categoryIds[this.Random.GetRandomNumber(0, categoryIds.Count - 1)]);
                    }

                    foreach (var uniqueCategoryId in uniqueCategoryIds)
                    {
                        currentToy.Categories.Add(this.Database.Categories.Find(uniqueCategoryId));
                    }
                }

                this.Database.Toys.Add(currentToy);

                if (i % 100 == 0)
                {
                    this.Database.SaveChanges();
                    Console.Write(".");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Toys added");
        }
    }
}
