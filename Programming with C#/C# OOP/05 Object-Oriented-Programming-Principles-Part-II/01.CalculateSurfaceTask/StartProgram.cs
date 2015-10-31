namespace _01.CalculateSurfaceTask
{
    using System;

    public class StartProgram
    {
        static void PrintingShapes(Shape[] shapes)
        {
            int rectangleCounter = 1;
            int triangleCounter = 1;
            int circleCounter = 1;

            foreach (var shape in shapes)
            {
                double result = shape.CalculateSurface();

                if (shape is Rectangle)
                {
                    Console.WriteLine("The surface of rectangle {0} is {1:F2}.", rectangleCounter, result);
                    rectangleCounter++;
                }

                if (shape is Triangle)
                {
                    Console.WriteLine("The surface of triangle {0} is {1:F2}.", triangleCounter, result);
                    triangleCounter++;
                }

                if (shape is Circle)
                {
                    Console.WriteLine("The surface of circle {0} is {1:F2}.", circleCounter, result);
                    circleCounter++;
                }
            }
        }
        static void Main()
        {
            Shape[] arrayOfShapes = new Shape[]
            {
                new Rectangle(2.5, 10),
                new Triangle(3, 3),
                new Circle(10),
                new Rectangle(3, 24.5)
            };

            PrintingShapes(arrayOfShapes);
        }
    }
}
