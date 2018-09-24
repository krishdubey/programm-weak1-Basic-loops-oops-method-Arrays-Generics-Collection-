using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionFramework
{
    class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",1010);
            ht.Add("Ename","Scott");
            ht.Add("Job","Manager");
            ht.Add("Salary",25000.00);
            ht.Add("Mgrid", 1002);
            ht.Add("Phone",23456666);
            ht.Add("Email","A@A");
            ht.Add("Dname","Sales");
            ht.Add("Location","Mumbai");
            ht.Add("Did",30);

            foreach (object key in ht.Keys)
                Console.WriteLine(key + " : " + ht[key]);
            Console.WriteLine();
            Console.WriteLine(ht["Email"]);
            Console.WriteLine();

           //  Console.WriteLine("Hello".GetHashCode());

            Console.ReadLine();
        }
    }
}
