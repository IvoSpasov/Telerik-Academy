// 02 Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. 
// Write a testing class.

namespace _01_NorthwindDatabaseFirst
{
    using System;
    using System.Linq;

    public class CustomersDAO
    {
        public static void AddCustomer(Customer newCustomer)
        {
            using (var db = new NorthwindEntities())
            {
                var existingCustomer = db.Customers
                    .FirstOrDefault(c => c.CustomerID == newCustomer.CustomerID);

                if (existingCustomer == null)
                {
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    Console.WriteLine("Customer added successfully.");
                }
                else
                {
                    Console.WriteLine("Can not add this customer. A customer with the same Id already exists.");
                }
            }
        }

        public static void UpdateCustomer(Customer updatedCustomer)
        {
            using (var db = new NorthwindEntities())
            {
                var existingCustomer = db.Customers
                    .FirstOrDefault(c => c.CustomerID == updatedCustomer.CustomerID);

                if (existingCustomer != null)
                {
                    if (updatedCustomer.CompanyName != null)
                    {
                        existingCustomer.CompanyName = updatedCustomer.CompanyName;
                    }
                    if (updatedCustomer.ContactName != null)
                    {
                        existingCustomer.ContactName = updatedCustomer.ContactName;
                    }
                    if (updatedCustomer.ContactTitle != null)
                    {
                        existingCustomer.ContactTitle = updatedCustomer.ContactTitle;
                    }
                    if (updatedCustomer.Address != null)
                    {
                        existingCustomer.Address = updatedCustomer.Address;
                    }
                    if (updatedCustomer.City != null)
                    {
                        existingCustomer.City = updatedCustomer.City;
                    }
                    if (updatedCustomer.Region != null)
                    {
                        existingCustomer.Region = updatedCustomer.Region;
                    }
                    if (updatedCustomer.PostalCode != null)
                    {
                        existingCustomer.PostalCode = updatedCustomer.PostalCode;
                    }
                    if (updatedCustomer.Country != null)
                    {
                        existingCustomer.Country = updatedCustomer.Country;
                    }
                    if (updatedCustomer.Phone != null)
                    {
                        existingCustomer.Phone = updatedCustomer.Phone;
                    }
                    if (updatedCustomer.Fax != null)
                    {
                        existingCustomer.Fax = updatedCustomer.Fax;
                    }

                    db.SaveChanges();
                    Console.WriteLine("Customer updated successfully.");
                }
                else
                {
                    Console.WriteLine("Cannot update unexisting customer.");
                }
            }
        }

        public static void DeleteCustomer(string customerId)
        {
            using (var db = new NorthwindEntities())
            {
                var existingCustomer = db.Customers
                    .FirstOrDefault(c => c.CustomerID == customerId);

                if (existingCustomer != null)
                {
                    var orders = db.Orders.Where(o => o.CustomerID == customerId);
                    if (orders != null)
                    {
                        foreach (var order in orders)
                        {
                            order.CustomerID = null;
                        }
                    }

                    db.Customers.Remove(existingCustomer);
                    db.SaveChanges();
                    Console.WriteLine("Customer deleted sucessfully.");
                }
                else
                {
                    Console.WriteLine("Cannot delete unexisting customer.");
                }
            }
        }
    }
}
