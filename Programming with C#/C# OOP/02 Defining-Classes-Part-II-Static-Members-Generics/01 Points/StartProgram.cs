namespace Points
{
    using System;
    using _04_Attributes;

    [Version(1.00)]
    public class StartProgram
    {
        public static void Main()
        {
            // Testing the point3D and point calculation calsses
            Point3D firstPoint = new Point3D(5, 10, 15);
            Point3D secondPoint = Point3D.StartPoint;
            double distance = PointsCalculation.Distance(firstPoint, secondPoint);
            Console.WriteLine("The distance between two points is: " + distance);
            Console.WriteLine();

            // testing the path and path storage classes
            // writing
            Point3D[] sequenceOfFive =
                                        {
                                        new Point3D(5, 10, 15),
                                        new Point3D(1, 2, 3),
                                        new Point3D(3, 1, 23),
                                        new Point3D(9, 4, 56),
                                        new Point3D(77, 3, 34), 
                                        };

            Path firstSequence = new Path(sequenceOfFive);
            string saveToPath = "../../Points Database.txt";
            PathStorage.Save(sequenceOfFive, saveToPath);

            // reading
            string loadFromPath = "../../Points Database.txt";
            Path secondSequence = new Path(PathStorage.Load(loadFromPath));

            foreach (var point in secondSequence.Sequence)
            {
                Console.WriteLine(point);
            }
        }
    }
}
