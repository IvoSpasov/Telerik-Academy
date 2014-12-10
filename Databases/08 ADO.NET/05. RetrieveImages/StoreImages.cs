// Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.

namespace _05.RetrieveImages
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    public class StoreImages
    {
        public static void Main()
        {
            // plase change according to your server name
            string serverName = "TOSHIBA-PC\\INSTANCEONE";
            SqlConnection dbCon = new SqlConnection("Server=" + serverName +
                    "; Database=Northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdGetPictures = new SqlCommand("SELECT CategoryName, Picture FROM Categories", dbCon);
                SqlDataReader reader = cmdGetPictures.ExecuteReader();
                using (reader)
                {
                    byte[] rawData;
                    string fileName;
                    int rawDataLength;
                    int header = 78;
                    byte[] imageData;
                    MemoryStream stream;
                    Image image;

                    while (reader.Read())
                    {
                        rawData = (byte[])reader["Picture"];
                        fileName = reader["CategoryName"].ToString().Replace('/', '_') + ".jpg";
                        rawDataLength = rawData.Length;
                        imageData = new byte[rawDataLength - header];
                        Array.Copy(rawData, header, imageData, 0, rawDataLength - header);

                        stream = new MemoryStream(imageData);
                        image = Image.FromStream(stream);
                        image.Save(new FileStream(fileName, FileMode.Create), ImageFormat.Jpeg);
                    }

                    Console.WriteLine("Images saved successfully!");
                }
            }
        }
    }
}