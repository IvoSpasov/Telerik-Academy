using System;
using System.Transactions;
using System.Data.SqlClient;

namespace TransactionsHomework
{
    class Program
    {
        private const string ConnectionString = "Server=TOSHIBA-PC\\INSTANCEONE; " +
        "Database=ATM; Integrated Security=true";

        static void Main(string[] args)
        {
        }

        private static void RetrieveMoney(decimal amount)
        {
            using (SqlConnection dbCon = new SqlConnection(ConnectionString))
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    dbCon.Open();

                    var account = dbCon.
                }
            }

        }
    }
}
