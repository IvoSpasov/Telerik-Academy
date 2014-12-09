namespace Phone
{
    using System;
    public class GSMCallHistoryTest
    {
        // Creating an instance of the GSM class.
        private static GSM nokia = new GSM("6210", "Nokia");

        // Adding a few calls.
        private static void CreateCalls()
        {
            nokia.AddCall(new Call(new DateTime(2014, 02, 01, 22, 16, 23), new DateTime(2014, 02, 01, 22, 20, 55), "0889876543"));
            nokia.AddCall(new Call(new DateTime(2014, 02, 01, 23, 27, 14), new DateTime(2014, 02, 01, 23, 29, 5), "0888765432"));
            nokia.AddCall(new Call(new DateTime(2014, 02, 02, 10, 5, 00), new DateTime(2014, 02, 02, 10, 25, 59)));
        }

        private static void PrintHistory()
        {
            Console.WriteLine("This is the {0} {1} phone call history:", nokia.Manufacturer, nokia.Model);
            Console.WriteLine();
            foreach (var call in nokia.CallHistory)
            {
                Console.WriteLine(call);
                Console.WriteLine();
            }
        }

        public static void Test()
        {
            // create the calls obviously
            CreateCalls();

            //Displaing the information about the calls.
            PrintHistory();

            // Calculating and printing the total price
            double pricePerMinute = 0.37;
            Console.WriteLine("The total price of the calls is: {0:C}", nokia.CalculateTotalPrice(pricePerMinute));

            // Removing the longest call
            double longestCall = double.MinValue;

            foreach (var call in nokia.CallHistory)
            {
                if (call.Duration > longestCall)
                {
                    longestCall = call.Duration;
                }
            }

            foreach (var call in nokia.CallHistory)
            {
                if (call.Duration == longestCall)
                {
                    nokia.DeleteCall(call);
                    break;
                }
            }

            Console.WriteLine("The total price of the calls whithout the longest one is: {0:C}",
                nokia.CalculateTotalPrice(pricePerMinute));
            Console.WriteLine();

            // Finally clearing the history

            nokia.ClearHistory();

            // and prining?? print what? why? It's empty. I dont'get it. There is nothing to print! The history of the noKia is cleared.

            PrintHistory();

            // see.. nothing
        }


    }
}
