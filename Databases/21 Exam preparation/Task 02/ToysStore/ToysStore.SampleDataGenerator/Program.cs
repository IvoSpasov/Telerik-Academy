namespace ToysStore.SampleDataGenerator
{
    using System.Collections.Generic;

    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.DataGenerators;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal class Program
    {
        private static void Main()
        {
            var random = RandomDataGenerator.Instance;
            var db = new ToysStoreEntities();
            // importante!!! fur speed.
            db.Configuration.AutoDetectChangesEnabled = false;

            // implement factory
            var listOfGenerators = new List<IDataGenerator>
            {
                new CategoryDataGenerator(random, db, 100),
                new ManufacturerDataGenerator(random, db, 50),
                new AgeRangeDataGenerator(random, db, 100),
                new ToyDataGenerator(random, db, 20000)
            };

            foreach (var generator in listOfGenerators)
            {
                generator.Generate();
                db.SaveChanges();
            }

            // return it back to normal so that we can update
            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}
