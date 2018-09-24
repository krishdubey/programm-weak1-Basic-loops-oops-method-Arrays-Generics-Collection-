using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            for (int i = 3; i <= 5; i++)
            {
                Console.WriteLine("loop body");
                Console.WriteLine("loop body:" + i);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("main-end");
            Console.Read();
        }
    }
}
