using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionFramework
{
    class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(10);
            Console.WriteLine(al.Capacity);
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add(6);
            al.Add(7);
            al.Add(8);
            al.Add(9);
            al.Add(10);
            Console.WriteLine(al.Capacity);
            al.Add(11);
            Console.WriteLine(al.Capacity);
            Console.WriteLine("normal ArrayList");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            al.Insert(3, 25);
            Console.WriteLine("Insert At Any Place In ArrayList");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            al.Remove(5);
            Console.WriteLine("Remove Element Of ArrayList");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            al.RemoveAt(8);
            Console.WriteLine("Remove Index Of ArrayList");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            Console.Read();
        }
    }
}
