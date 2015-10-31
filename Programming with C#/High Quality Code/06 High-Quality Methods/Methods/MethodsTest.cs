namespace Methods
{
    using System;

    public class MethodsTest
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(Methods.DigitToWord(5));
            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsFloat(1);
            Methods.PrintAsPercentage(0.75);
            Methods.PrintWithRightPadding(2.30);

            var point1 = new { x = 3, y = -1 };
            var point2 = new { x = 3, y = 2.5 };
            bool horizontal = Methods.IsLineHorizontal(point1.x, point2.x);
            bool vertical = Methods.IsLineVertical(point1.y, point2.y);
            Console.WriteLine(Methods.CalculateDistance(point1.x, point1.y, point2.x, point2.y));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            var peter = new Student("Peter", "Ivanov", DateTime.Parse("17.03.1992"));
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            var stella = new Student("Stella", "Markova", DateTime.Parse("03.11.1993"));
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("Is {0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
