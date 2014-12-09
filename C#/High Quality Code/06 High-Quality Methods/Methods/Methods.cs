namespace Methods
{
    using System;

    class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The sum of any two sides should be greater than the length of the third side.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
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
                default: throw new ArgumentException("Invalid number!");
            }
        }

        static int FindMax(params int[] elements)
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

        static void PrintAsNumber(double number, string format)
        {
            switch (format)
            {
                case "f": Console.WriteLine("{0:f2}", number); break;
                case "%": Console.WriteLine("{0:p0}", number); break;
                case "r": Console.WriteLine("{0,8}", number); break;
                default: throw new ArgumentException("Wrong format. Format should be \"f\", \"%\" or \"r\".");
            }
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool CheckIfLineIsHorizontal(double x1, double x2)
        {
            bool isHorizontal = (x1 == x2);

            return isHorizontal;
        }

        public static bool CheckIfLineIsVertical(double y1, double y2)
        {
            bool isVertical = (y1 == y2);

            return isVertical;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            var point1 = new { x = 3, y = -1 };
            var point2 = new { x = 3, y = 2.5 };
            bool horizontal = CheckIfLineIsHorizontal(point1.x, point2.x);
            bool vertical = CheckIfLineIsVertical(point1.y, point2.y);
            Console.WriteLine(CalculateDistance(point1.x, point1.y, point2.x, point2.y));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", DateTime.Parse("17.03.1992"));
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova", DateTime.Parse("03.11.1993"));
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
