using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Test1
    {
        public void Test11()
        {
            Console.WriteLine("Method 1");
        }
        public void Test12()
        {
            Console.WriteLine("Method 2");
        }

        static void Main(string[] args)
        {
            Test1 t1 = new Test1();
            t1.Test11();
            t1.Test12();
            Console.Read(); 
        }

    }
}
