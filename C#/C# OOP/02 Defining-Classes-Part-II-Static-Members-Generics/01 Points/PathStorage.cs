namespace Points
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void Save(Point3D[] sequence, string path)
        {
            StreamWriter writer = new StreamWriter(path);

            try
            {
                using (writer)
                {
                    int counter = 1;

                    foreach (var point in sequence)
                    {
                        writer.WriteLine("Point {0}: {1}, {2}, {3}", counter, point.X, point.Y, point.Z);
                        counter++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file to read from is missing.");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: {0}.", exc.Message);
            }
        }

        public static Point3D[] Load(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<Point3D> pointsList = new List<Point3D>();

            try
            {
                using (reader)
                {
                    string line = null;

                    while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                    {
                        string[] separators = { "Point", ":", "," };
                        string[] lineArr = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        pointsList.Add(new Point3D(int.Parse(lineArr[1]), int.Parse(lineArr[2]), int.Parse(lineArr[3])));
                    }
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: {0}.", exc.Message);
            }            

            Point3D[] pointArray = new Point3D[pointsList.Count];

            for (int i = 0; i < pointsList.Count; i++)
            {
                pointArray[i] = pointsList[i];
            }

            return pointArray;
        }
    }
}
