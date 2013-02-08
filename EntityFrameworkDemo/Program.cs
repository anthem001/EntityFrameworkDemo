using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* instantiate entity object */
            AdventureWorksLT2008R2Entities entities = new AdventureWorksLT2008R2Entities();

            /* LINQ query */
            IEnumerable<Customer> customers = from c in entities.Customers
                            select c;

            /* iterate over enumerable */
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} {2} {3}", customer.Title, customer.FirstName, customer.LastName, customer.Suffix);
            }

            /* pause to view output */
            Console.ReadLine();

        }
    }
}
