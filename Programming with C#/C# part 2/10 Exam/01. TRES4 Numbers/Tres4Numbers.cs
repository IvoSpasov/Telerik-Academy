namespace _01.TRES4_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tres4Numbers
    {
        public static void Main()
        {
            ulong decimalInput = ulong.Parse(Console.ReadLine());
            List<int> nonaryResult = ConvertToNonaryNumeralSystem(decimalInput);
            string tresnum4 = ConvertToTresnum4(nonaryResult);
            Console.WriteLine(tresnum4);
        }

        public static List<int> ConvertToNonaryNumeralSystem(ulong decimalNumber)
        {
            ulong resultFromDivision;
            int remainderFromDivision;
            List<int> resultInNonary = new List<int>();

            resultFromDivision = decimalNumber / 9;
            remainderFromDivision = Convert.ToInt32(decimalNumber % 9);
            resultInNonary.Add(remainderFromDivision);

            while (resultFromDivision != 0)
            {
                remainderFromDivision = Convert.ToInt32(resultFromDivision % 9);
                resultInNonary.Add(remainderFromDivision);
                resultFromDivision /= 9;
            }

            resultInNonary.Reverse();
            return resultInNonary;
        }

        public static string ConvertToTresnum4(List<int> nonaryNumbers)
        {
            string[] digitsInTresnum4 = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
            StringBuilder tresnum4 = new StringBuilder();

            foreach (var number in nonaryNumbers)
            {
                tresnum4.Append(digitsInTresnum4[number]);
            }

            return tresnum4.ToString();
        }
    }
}
