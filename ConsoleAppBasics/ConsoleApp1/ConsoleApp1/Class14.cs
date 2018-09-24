using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class14
    {
        static void Main(string[] args)
        {
            int i = 20;
            for (i = 0; i <= 70; i += 10)

            {
                Console.WriteLine("loop body");
                Console.WriteLine("loop body:" + i);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("main-end:" + i);
        }
}
}
