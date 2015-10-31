namespace _01_ProperNaming
{
    using System;

    public class ProgramStart
    {
        public static void Main()
        {
            Size rectangle = new Size(3, 5);
            Size rotatedRectangle = GetRotatedSize(rectangle, 90);
            Console.WriteLine("Rotated width is: " + rotatedRectangle.Width);
            Console.WriteLine("Rotated height is: " + rotatedRectangle.Height);
        }

        public static Size GetRotatedSize(Size figure, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            double calculatedWidth = (Math.Abs(Math.Cos(angleInRadians)) * figure.Width) + (Math.Abs(Math.Sin(angleInRadians)) * figure.Height);
            double caluclatedHeight = (Math.Abs(Math.Sin(angleInRadians)) * figure.Width) + (Math.Abs(Math.Cos(angleInRadians)) * figure.Height);
            Size rotatedSize = new Size(calculatedWidth, caluclatedHeight);
            return rotatedSize;
        }
    }
}
