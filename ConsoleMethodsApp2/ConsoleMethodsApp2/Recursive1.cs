using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Recursive1
    {
        public static void test(int x)
        {
            if(x==0)
            {
                return;
            }
            Console.WriteLine(x);
            --x;
            test(x);
            Console.Read();
        }
        static void Main(string[] args)
        {
            test(10);
        }
    }
}
