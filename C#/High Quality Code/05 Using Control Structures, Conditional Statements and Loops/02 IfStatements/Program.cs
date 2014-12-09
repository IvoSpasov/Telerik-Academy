// Refactor the following if statements:

namespace _02_IfStatements
{
    using System;
    
    class Program
    {
        static void Main()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            if ((MIN_X <= x) && (x <= MAX_X) && (MIN_Y <= y) && (y <= MAX_Y) && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}