// Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.

namespace ADO.NETHomework
{
    using System;
    using System.Data.SqlClient;

    class RetrieveNumberOfRows
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
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int numberOfRows = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("The rows count in the Categories table is: " + numberOfRows);
            }
        }
    }
}
