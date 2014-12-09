namespace Phone
{
    public class GSMTest
    {
        private static GSM[] gsmArray = 
        {
            new GSM("K530i", "Sony Ericsson", 50, "Johann Sebastian Bach", new Battery("BST-33", BatteryType.LiPoly, 5, 50), new Display("176 x 220", "262k")),
            new GSM("6320i", "Nokia", 0, null, new Battery(), new Display(null, "65K")),
            new GSM("Desire 501", "HTC", 0, "Wolfgang Amadeus Mozart", new Battery(null, BatteryType.LiIon), new Display("4.3 inch", "16M"))
        };

        public static void Test()
        {
            foreach (var phone in gsmArray)
            {
                System.Console.WriteLine(phone);
                System.Console.WriteLine();
            }

            System.Console.WriteLine(GSM.IPhone4S);
        }
    }
}
