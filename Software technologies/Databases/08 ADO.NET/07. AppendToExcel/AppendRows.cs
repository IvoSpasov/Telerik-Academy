namespace _07.AppendToExcel
{
    using System;
    using System.Data.OleDb;

    class AppendRows
    {
        static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Users.xlsx;" +
                @"Extended Properties=""Excel 12.0 Xml;HDR=YES"";";
            OleDbConnection dbCon = new OleDbConnection(connectionString);
            dbCon.Open();

            using (dbCon)
            {
                OleDbCommand cmdInsertNameAndScore = new OleDbCommand("INSERT INTO [Users$] (Name, Score) VALUES (@name, @score)", dbCon);
                cmdInsertNameAndScore.Parameters.AddWithValue("@name", "Pesho");
                cmdInsertNameAndScore.Parameters.AddWithValue("@score", 30);
                cmdInsertNameAndScore.ExecuteNonQuery();
                Console.WriteLine("User added successfully");
            }
        }
    }
}
