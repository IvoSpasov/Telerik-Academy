using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TradeCompany
{
    class Article: IComparable<Article>
    {
        public Article(string barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string Barcode { get; set; }
        public string Vendor { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            string article = string.Format("{0} from {1} with barcode {2} and price -> {3:C2}",
                this.Title, this.Vendor, this.Barcode, this.Price);
            return article;
        }

        public int CompareTo(Article otherArticle)
        {
            return this.Price.CompareTo(otherArticle.Price);
        }
    }
}
