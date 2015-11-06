// Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

namespace _04.AddInNorthwind
{
    using System;
    using System.Data.SqlClient;

    class ProductAdd
    {
        private SqlConnection dbCon;

        private void ConnectToDB()
        {
            dbCon = new SqlConnection(Settings.Default.DBConnectionString);
            dbCon.Open();
        }

        private void DisconnectFromDB()
        {
            if (dbCon != null)
            {
                dbCon.Close();
            }
        }

        private int AddNewProductInNorthwind(Product newProduct)
        {
            SqlParameter currentSqlParam;
            SqlCommand cmdInsertProduct = new SqlCommand(
                "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, " +
                "UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@productName, @supplierId, " +
                "@categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbCon);

            cmdInsertProduct.Parameters.AddWithValue("@productName", newProduct.ProductName);

            currentSqlParam = AddNullableParameter("@supplierId", newProduct.SupplierId);
            cmdInsertProduct.Parameters.Add(currentSqlParam);

            currentSqlParam = AddNullableParameter("@categoryId", newProduct.CategoryId);
            cmdInsertProduct.Parameters.Add(currentSqlParam);
                        
            cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", newProduct.QuantityPerUnit);

            currentSqlParam = AddNullableParameter("@unitPrice", newProduct.UnitPrice);
            cmdInsertProduct.Parameters.Add(currentSqlParam);

            currentSqlParam = AddNullableParameter("@unitsInStock", newProduct.UnitsInStock);
            cmdInsertProduct.Parameters.Add(currentSqlParam);

            currentSqlParam = AddNullableParameter("@unitsOnOrder", newProduct.UnitsOnOrder);
            cmdInsertProduct.Parameters.Add(currentSqlParam);

            currentSqlParam = AddNullableParameter("@reorderLevel", newProduct.ReorderLevel);
            cmdInsertProduct.Parameters.Add(currentSqlParam);

            cmdInsertProduct.Parameters.AddWithValue("@discontinued", newProduct.Discontinued);

            cmdInsertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            return insertedRecordId;
        }

        private SqlParameter AddNullableParameter(string paramName, object paramValue)
        {
            SqlParameter sqlParam = new SqlParameter(paramName, paramValue);
            if (paramValue == null)
            {
                sqlParam.Value = DBNull.Value;
            }

            return sqlParam;
        }

        static void Main()
        {
            ProductAdd example = new ProductAdd();
            try
            {
                example.ConnectToDB();
                Product firstProduct = new Product("Bicycle", 1, 1, "One", 202.15m, 5, 2, 10, false);
                Product secondProduct = new Product("Phone", null, null, "ten in one box", 999.99m, 10, null, 10, false);
                int newProductId = example.AddNewProductInNorthwind(firstProduct);
                Console.WriteLine("Inserted new product with id = " + newProductId);
                newProductId = example.AddNewProductInNorthwind(secondProduct);
                Console.WriteLine("Inserted new product with id = " + newProductId);
            }
            finally
            {
                example.DisconnectFromDB();
            }
        }
    }
}
