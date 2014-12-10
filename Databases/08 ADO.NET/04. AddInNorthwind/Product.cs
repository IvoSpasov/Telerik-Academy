namespace _04.AddInNorthwind
{
    using System;

    class Product
    {
        public Product(string productName, int? supplierId, int? categoryId, string quantityPerUnit,
            decimal? unitPrice, int? unitsInStock, int? unitsOnOrder, int? reorderLevel, bool discontinued)
        {
            this.ProductName = productName;
            this.SupplierId = supplierId;
            this.CategoryId = categoryId;
            this.QuantityPerUnit = quantityPerUnit;
            this.UnitPrice = unitPrice;
            this.UnitsInStock = unitsInStock;
            this.UnitsOnOrder = unitsOnOrder;
            this.ReorderLevel = reorderLevel;
            this.Discontinued = discontinued;
        }

        public string ProductName { get; set; }

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitsInStock { get; set; }

        public int? UnitsOnOrder { get; set; }

        public int? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }
}