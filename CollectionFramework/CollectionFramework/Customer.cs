using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
   public class Customer
    {
        public int Custid { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public double Balance { get; set; }
    }

    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer { Custid = 101, Name = "bizrun", City = "Delhi", Balance = 25000 };
            Customer c2 = new Customer { Custid = 102, Name = "bizrun", City = "Delhi", Balance = 25000 };
            Customer c3 = new Customer { Custid = 103, Name = "bizrun", City = "Delhi", Balance = 25000 };
            Customer c4 = new Customer { Custid = 104, Name = "bizrun", City = "Delhi", Balance = 25000 };

            customers.Add(c1);customers.Add(c2);customers.Add(c3);customers.Add(c4);
            foreach(Customer obj in customers)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name  + " " + obj.City  + " " + obj.Balance);
                
            }
            Console.WriteLine();
            Console.Read();

        }

    }
}
