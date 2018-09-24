using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class Generics2
    {
        public bool Compare(object a, object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Generics2 obj1 = new Generics2();
            bool result = obj1.Compare(10, 10);
           // bool result1 = obj1.Compare(2.5f, 2.5);
            // i want to compare float but here not compare float only so no type 
            Console.WriteLine(result);
           // Console.WriteLine(result1);
            Console.Read();
        }
    }
}
