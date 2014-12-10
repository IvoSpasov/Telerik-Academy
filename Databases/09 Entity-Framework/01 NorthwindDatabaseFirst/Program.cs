namespace _01_NorthwindDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            //// Please uncomment different tasks

            //// task 02
            //var customerToAdd = new Customer
            //{
            //    CustomerID = "DDZ",
            //    CompanyName = "De da znam",
            //    ContactName = "Pesho",
            //    Country = "Bulgaria"
            //};

            //CustomersDAO.AddCustomer(customerToAdd);

            //var customerToModify = new Customer
            //{
            //    CustomerID = "DDZ",
            //    Fax = "1234",
            //    Phone = "45535342342"
            //};

            //CustomersDAO.UpdateCustomer(customerToModify);

            //CustomersDAO.DeleteCustomer("DRACD");

            //// 03 Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            //var customers = FindCustomersByOrderYearAndCountry(new DateTime().AddYears(1997 - 1), "Canada")
            //    .Select(c =>
            //        new
            //        {
            //            ContactName = c.ContactName,
            //            CompanyName = c.CompanyName,
            //            Country = c.Country
            //        });

            //Console.WriteLine("All customers who have orders made in 1997 and shipped to Canada are:");
            //foreach (var customer in customers)
            //{

            //    Console.WriteLine("{0} from the company {1} in {2}", customer.ContactName, customer.CompanyName, customer.Country);
            //}

            //// 04 Implement previous by using native SQL query and executing it through the DbContext.
            //FindCustomersUsingNativeSQL(new DateTime().AddYears(1997 - 1), "Canada");

            //// 05 Write a method that finds all the sales by specified region and period (start / end dates).
            //var sales = FindAllSalesByRegionAndPeriod("NM", new DateTime(1997, 1, 1), new DateTime(1998, 1, 1));

            //foreach (var sale in sales)
            //{
            //    Console.WriteLine("{0} to {1}", sale.ShipName, sale.ShipCity);
            //}
        }

        // 03 Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        private static List<Customer> FindCustomersByOrderYearAndCountry(DateTime orderDate, string shipCountry)
        {
            using (var db = new NorthwindEntities())
            {
                List<Customer> customers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == orderDate.Year)
                    .Where(o => o.ShipCountry == shipCountry)
                    .Select(o => o.Customer)
                    .Distinct()
                    .ToList();

                return customers;
            }
        }

        // 04 Implement previous by using native SQL query and executing it through the DbContext.
        private static void FindCustomersUsingNativeSQL(DateTime orderDate, string shipCountry)
        {
            string sqlQuery =
                "SELECT DISTINCT " +
                    "c.CustomerID, " +
                    "c.CompanyName, " +
                    "c.ContactName, " +
                    "c.ContactTitle, " +
                    "c.Address, " +
                    "c.City, " +
                    "c.Region, " +
                    "c.PostalCode, " +
                    "c.Country, " +
                    "c.Phone, " +
                    "c.Fax " +
                "FROM Orders o " +
                    "LEFT OUTER JOIN Customers c " +
                        "ON o.CustomerID = c.CustomerID " +
                "WHERE " +
                "(DATEPART (year, o.OrderDate) = DATEPART (year, @orderDate)) AND " +
                "(o.ShipCountry = @shipCountry)";

            using (var db = new NorthwindEntities())
            {
                var a = new SqlParameter("@orderDate", orderDate);
                var b = new SqlParameter("@shipCountry", shipCountry);

                int customers = db.Database
                    .ExecuteSqlCommand(sqlQuery, a, b);

                Console.WriteLine(customers);
            }
        }

        // 05 Write a method that finds all the sales by specified region and period (start / end dates).
        private static List<Order> FindAllSalesByRegionAndPeriod(string shipRegion, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                List<Order> sales = db.Orders
                    .Where(o => o.ShipRegion == shipRegion)
                    .Where(o => o.OrderDate >= startDate)
                    .Where(o => o.OrderDate <= endDate)
                    .ToList();

                return sales;
            }
        }
    }
}
