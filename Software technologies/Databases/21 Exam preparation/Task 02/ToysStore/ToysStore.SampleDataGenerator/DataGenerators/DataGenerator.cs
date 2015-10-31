namespace ToysStore.SampleDataGenerator.DataGenerators
{
    using ToysStore.Data;
    using ToysStore.SampleDataGenerator.RandomGenerator;

    internal abstract class DataGenerator : IDataGenerator
    {
        private IRandomDataGenerator random;
        private ToysStoreEntities db;
        private int count;

        public DataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreDatabase, int countOfGeneratedObjects)
        {
            this.random = randomDataGenerator;
            this.db = toysStoreDatabase;
            this.count = countOfGeneratedObjects;
        }

        protected IRandomDataGenerator Random
        {
            get { return this.random; }
        }

        protected ToysStoreEntities Database
        {
            get { return this.db; }
        }

        protected int Count
        {
            get { return this.count; }
        }

        public abstract void Generate();
    }
}
