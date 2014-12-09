using System;
using System.Threading;
using System.Globalization;


class Garden
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double tomatoSeeds = double.Parse(Console.ReadLine()), tomatoArea = double.Parse(Console.ReadLine()), tomatoCost = 0.5;
        double cucumberSeeds = double.Parse(Console.ReadLine()), cucumberArea = double.Parse(Console.ReadLine()), cucumberCost = 0.4;
        double potatoSeeds = double.Parse(Console.ReadLine()), potatoArea = double.Parse(Console.ReadLine()), potatoCost = 0.25;
        double carrotSeeds = double.Parse(Console.ReadLine()), carrotArea = double.Parse(Console.ReadLine()), carrotCost = 0.6;
        double cabbageSeeds = double.Parse(Console.ReadLine()), cabbageArea = double.Parse(Console.ReadLine()), cabbageCost = 0.3;
        double beansSeeds = double.Parse(Console.ReadLine()), beansArea, beansCost = 0.4;
        double totalCost;
        double totalAvailableArea = 250, totalCalculatedArea;

        totalCost = (tomatoSeeds * tomatoCost) + (cucumberSeeds * cucumberCost) + (potatoSeeds * potatoCost) +
                    (cabbageSeeds * cabbageCost) + (carrotSeeds * carrotCost) + (beansSeeds * beansCost);
        Console.WriteLine("Total costs: {0:0.00}", totalCost);

        totalCalculatedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        beansArea = totalAvailableArea - totalCalculatedArea;

        if (totalCalculatedArea < totalAvailableArea)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (totalCalculatedArea > totalAvailableArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else
        {
            Console.WriteLine("No area for beans");
        }
    }
}

//score 100/100