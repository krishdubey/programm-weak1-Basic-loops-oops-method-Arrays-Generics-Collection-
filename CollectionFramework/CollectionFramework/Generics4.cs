using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class Generics4<T>
    {
        public void Add(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1*d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1/d2);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Generics4<int> obj1 = new Generics4<int>();
            obj1.Add(10,10);obj1.Sub(20,10);obj1.Mul(1,2);obj1.Div(10,5);
            Console.ReadLine();
        }
    }
}
