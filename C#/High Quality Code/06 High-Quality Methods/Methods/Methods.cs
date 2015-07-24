namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sum of any two sides should be greater than the length of the third side.");
            }

            double semiperimeter  = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter  * (semiperimeter  - sideA) * (semiperimeter  - sideB) * (semiperimeter  - sideC));
            return area;
        }

        public static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input can not be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("No elements were passed to the method.");
            }

            int maxElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (maxElement < elements[i])
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static void PrintAsFloat(double number)
        {
            Console.WriteLine("{0:f2}", number); 
        }

        public static void PrintAsPercentage(double number)
        {
            Console.WriteLine("{0:p0}", number); 
        }

        public static void PrintWithRightPadding(double number)
        {
            Console.WriteLine("{0,8}", number); 
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool IsLineHorizontal(double x1, double x2)
        {
            return x1 == x2;
        }

        public static bool IsLineVertical(double y1, double y2)
        {
            return y1 == y2;
        }
    }
}
