using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            int i = 1;
            while(i<=50)
            {
                Console.WriteLine("loop body:" + i);
                i += 10;
            }
            Console.WriteLine("main end:" + i);
            Console.ReadLine();
        }
    }
}
