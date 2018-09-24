using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class List1
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);
            li.Add(60);

            Console.WriteLine("List Of Element:-");
            for (int i = 0; i < li.Count; i++)
                Console.Write(li[i] + " ");

            Console.WriteLine();

            li.Insert(3, 35);//Insert element in 3rd Place
            Console.WriteLine("\nElement Of List:-");
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            li.RemoveAt(2);//we r removing element at index 2 means li[3]
            Console.WriteLine("\nElement Of List");
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();
      
            Console.ReadLine();
        }
    }
}
