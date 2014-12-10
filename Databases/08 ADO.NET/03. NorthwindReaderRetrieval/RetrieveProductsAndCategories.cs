// Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. 
// Can you do this with a single SQL query (with table join)?


namespace _03.NorthwindReaderRetrieval
{
    using System;
    using System.Data.SqlClient;

    class RetrieveProductsAndCategories
    {
        static void Main()
        {
            // plase change according to your server name
            string serverName = "TOSHIBA-PC\\INSTANCEONE";
            SqlConnection dbCon = new SqlConnection("Server=" + serverName +
            "; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdAllProductsAndCategories = new SqlCommand(
                    "SELECT p.ProductName, c.CategoryName FROM Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID", dbCon);
                SqlDataReader reader = cmdAllProductsAndCategories.ExecuteReader();
                using (reader)
                {
                    string product;
                    string category;
                    while (reader.Read())
                    {
                        product = (string)reader["ProductName"];
                        category = (string)reader["CategoryName"];
                        Console.WriteLine("{0} -> {1}", product, category);
                    }
                }
            }
        }
    }
}
