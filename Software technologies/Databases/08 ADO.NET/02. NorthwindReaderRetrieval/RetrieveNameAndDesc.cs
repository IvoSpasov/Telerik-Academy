// Write a program that retrieves the name and description of all categories in the Northwind DB.

namespace _02.NorthwindReaderRetrieval
{
    using System;
    using System.Data.SqlClient;

    class RetrieveNameAndDesc
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
                SqlCommand cmdAllNamesAndCat = new SqlCommand(
                    "SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = cmdAllNamesAndCat.ExecuteReader();
                using(reader)
                {
                    string catName;
                    string description;
                    while (reader.Read())
                    {
                        catName = (string)reader["CategoryName"];
                        description = (string)reader["Description"];
                        Console.WriteLine("{0} -> {1}", catName, description);
                    }
                }
            }
        }
    }
}
