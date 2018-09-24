using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            int i = 1;
            while(i < 5)
            {
                Console.WriteLine("loop body:" + i);
                i++;
            }
            Console.WriteLine("main end:" + i);
            Console.Read();
        }
    }
}
