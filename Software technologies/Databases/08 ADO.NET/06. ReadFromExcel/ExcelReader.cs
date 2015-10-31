// Create an Excel file with 2 columns: name and score:
// Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.

namespace _06.ReadFromExcel
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    class ExcelReader
    {
        static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Users.xlsx;" +
                @"Extended Properties=""Excel 12.0 Xml;HDR=YES"";";
            OleDbConnection dbCon = new OleDbConnection(connectionString);
            dbCon.Open();

            using (dbCon)
            {
                OleDbCommand cmdSelectNameAndScore = new OleDbCommand("SELECT Name, Score FROM [Users$]", dbCon);
                OleDbDataReader reader = cmdSelectNameAndScore.ExecuteReader();
                using (reader)
                {
                    string name;
                    double score;
                    while (reader.Read())
                    {
                        name = reader["Name"].ToString();
                        score = (double)reader["Score"];
                        Console.WriteLine(name + " " + score);
                    }
                }


                Console.WriteLine();
                Console.WriteLine("Second Way");
                DataTable dataSet = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Name, Score FROM [Users$]", dbCon);
                adapter.Fill(dataSet);

                foreach (DataRow item in dataSet.Rows)
                {
                    Console.WriteLine("{0} -> {1}", item.ItemArray[0], item.ItemArray[1]);
                }
            }
        }
    }
}