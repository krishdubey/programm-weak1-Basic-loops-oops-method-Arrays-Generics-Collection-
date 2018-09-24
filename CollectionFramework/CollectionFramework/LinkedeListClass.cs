using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class LinkedeListClass
    {
        public static void Main(string[] args)
        {
            
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");


            LinkedListNode<String> node = names.Find("Peter");// insert new element before Peter
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
