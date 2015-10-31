namespace _02_TradeCompany
{
    using System;
    using Wintellect.PowerCollections;

    public class Program
    {
        private static readonly Random rand = new Random();

        public static void Main()
        {
            int numberOfArticlels = 50;
            var articles = CreateMultipleArticles(numberOfArticlels);
            decimal fromPrice = 400.00m;
            decimal toPrice = 550.00m;
            var articlesInRange = articles.Range(fromPrice, true, toPrice, true);

            Console.WriteLine(string.Join(Environment.NewLine, articlesInRange.Values));
        }

        private static OrderedMultiDictionary<decimal, Article> CreateMultipleArticles(int numberOfArticles)
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(false);

            for (int i = 0; i < numberOfArticles; i++)
            {
                string barcode = GenerateRandomBarcode();
                string vendor = "Vendor " + i;
                string title = "Title " + i;
                double minPrice = 0.01;
                double maxPrice = 1000.00;
                decimal price = GenerateRandomPrice(minPrice, maxPrice);
                var currentArticle = new Article(barcode, vendor, title, price);
                articles.Add(price, currentArticle);
            }

            return articles;
        }

        private static string GenerateRandomBarcode()
        {
            int randomInt = rand.Next(0, 100000000);
            return randomInt.ToString();
        }

        private static decimal GenerateRandomPrice(double minPrice, double maxPrice)
        {
            var randomDouble = (rand.NextDouble() * (maxPrice - minPrice)) + minPrice;
            var randomPrice = (decimal)Math.Round(randomDouble, 2);
            return randomPrice;
        }
    }
}
