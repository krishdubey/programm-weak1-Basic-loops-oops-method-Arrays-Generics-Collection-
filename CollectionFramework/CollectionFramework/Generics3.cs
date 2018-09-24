using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class Generics3
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Generics3 obj1 = new Generics3();
            bool result = obj1.Compare<int>(10, 10);// here no boxing and unboxing
           // bool result1 = obj1.Compare<float>(10.5f, 10.5); //so it is type safe
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
