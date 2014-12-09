// Refactor the following code to use proper variable naming and simplified expressions:

namespace _01_ProperNaming
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Size rectangle = new Size(3, 5);
            Size rotatedRectangle = GetRotatedSize(rectangle, 90);
            Console.WriteLine("Rotated width is: " + rotatedRectangle.Width);
            Console.WriteLine("Rotated height is: " + rotatedRectangle.Height);
        }

        public static Size GetRotatedSize(Size figure, double figureAngleInDegrees)
        {
            double figureAngleInRadians = figureAngleInDegrees * Math.PI / 180;
            double calculatedWidth = Math.Abs(Math.Cos(figureAngleInRadians)) * figure.Width + Math.Abs(Math.Sin(figureAngleInRadians)) * figure.Height;
            double caluclatedHeight = Math.Abs(Math.Sin(figureAngleInRadians)) * figure.Width + Math.Abs(Math.Cos(figureAngleInRadians)) * figure.Height;
            Size rotatedSize = new Size(calculatedWidth, caluclatedHeight);
            return rotatedSize;
        }
    }
}
