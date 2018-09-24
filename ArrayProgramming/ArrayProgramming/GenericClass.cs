using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class GenericClass1<G1 , G2>
    {
        public void Display(G1 s1, G2 s2)
        {
            Console.WriteLine("The Value of s1 and s2: {0},{1}", s1, s2);
        }

    }

    class GenericClass2
    {
        static void Main(string[] args)
        {
            GenericClass1<string, int> obj1 = new GenericClass1<string, int>();
            GenericClass1<int, float> obj2 = new GenericClass1<int, float>();
            GenericClass1<double, float> obj3 = new GenericClass1<double, float>();
            obj1.Display("krishna", 1);
            obj2.Display(2, 2.2f);
            obj3.Display(2.5, 3.5f);
            Console.Read();
        }
    }
}
