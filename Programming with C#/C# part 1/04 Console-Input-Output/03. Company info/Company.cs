using System;

    class Company
    {
        static void Main()
        {
            string companyName, companyAddress, companyWebsite, firstName, lastName;
            int companyPhone, companyFax, managerPhone;
            byte age;
            bool parseSuccess = true;

            Console.WriteLine("This program reads the information about a company and it's manager and prints\nit on the screen.");
            Console.Write("Please enter company name: ");
            companyName = Console.ReadLine();
            Console.Write("Please enter company address: ");
            companyAddress = Console.ReadLine();

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Plese enter a valid company phone number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out companyPhone);
                }
                else
                {
                    Console.Write("Plese enter company phone number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out companyPhone);
                }

            } while (parseSuccess == false);
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Plese enter a valid company fax number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out companyFax);
                }
                else
                {
                    Console.Write("Plese enter company fax number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out companyFax);
                }

            } while (parseSuccess == false);

            Console.Write("Please enter company website: ");
            companyWebsite = Console.ReadLine();
            Console.Write("Please enter manager's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter manager's last name: ");
            lastName = Console.ReadLine();
          
            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please enter a valid age: ");
                    parseSuccess = (byte.TryParse(Console.ReadLine(), out age)) && (age >= 18) && (age <= 100);
                }
                else
                {
                    Console.Write("Please enter manager's age: ");
                    parseSuccess = (byte.TryParse(Console.ReadLine(), out age)) && (age >= 18) && (age <= 100);
                }

            } while (parseSuccess == false);
            // In my mind, the age of the manager should be between 18 and 100. It can always be changed.

            do
            {
                if (parseSuccess == false)
                {
                    Console.Write("Please enter a valid phone number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out managerPhone);
                }
                else
                {
                    Console.Write("Please enter manager's phone number: ");
                    parseSuccess = int.TryParse(Console.ReadLine(), out managerPhone);
                }

            } while (parseSuccess == false);


            Console.WriteLine();
            Console.WriteLine("This is the information you've just typed in:");
            Console.WriteLine();
            Console.WriteLine("Company name: " + companyName);
            Console.WriteLine("Company address: " + companyAddress);
            Console.WriteLine("Company phone number: " + companyPhone);
            Console.WriteLine("Company fax number: " + companyFax);
            Console.WriteLine("Company website: " + companyWebsite);
            Console.WriteLine("Manager's first name: " + firstName);
            Console.WriteLine("Manager's last name: " + lastName);
            Console.WriteLine("Manager's age: " + age);
            Console.WriteLine("Manager's phone number: " + managerPhone);
            Console.WriteLine();
        }
    }


