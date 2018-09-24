using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClassStaticConstructor
    {
        int i;
        static int j;

        public ClassStaticConstructor()
        {
            i = 10;
        }
        static ClassStaticConstructor()
        {
            j = 10;
        }
        public void Display()
        {
            Console.WriteLine("value of i is:" + i);
            i++;
            Console.WriteLine("value of j is :" + j);
            j++;
        }
    }
    class Uses
    {
        static void Main(string[] args)
        {
            ClassStaticConstructor obj1 = new ClassStaticConstructor();
            obj1.Display();

            ClassStaticConstructor obj2 = new ClassStaticConstructor();
            obj2.Display();

            ClassStaticConstructor obj3 = new ClassStaticConstructor();
            obj3.Display();

            Console.Read();
        }
    }
}
