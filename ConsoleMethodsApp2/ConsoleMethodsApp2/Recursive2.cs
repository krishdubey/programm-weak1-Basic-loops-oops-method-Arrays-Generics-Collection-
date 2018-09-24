using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Recursive2
    {
        public static void test(int i)
        {
            if(i==10)
            {
                return;
            }
            Console.Write(i);
            ++i;
            test(i);
            Console.Read();
        }
        static void Main(string[] args)
        {
            test(1);
        }
    }
}
