namespace OOP_Training
{
    using System;

    public class FractionTest
    {
        public static void Main(string[] args)
        {
            Fraction fract = new Fraction("18/48");
            Console.WriteLine(fract);
            Console.WriteLine(fract.DecimalValue);
            fract.CancelFraction();
            Console.WriteLine(fract);
        }
    }
}
