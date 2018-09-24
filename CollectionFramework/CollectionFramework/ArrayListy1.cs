using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionFramework
{
    class ArrayListy1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add("A");
            al.Add(100);
            al.Add(200);
            al.Add(null);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            al.Add(600);
            Console.WriteLine(al.Capacity);
            foreach (object obj in al) 
            Console.WriteLine(obj + " " );
            Console.Read();
        }
    }
}
