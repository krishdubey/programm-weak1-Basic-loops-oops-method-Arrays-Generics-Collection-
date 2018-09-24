using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            int i = 10;
            while(i >= 5)
            {
                Console.WriteLine("body of loops:" + i);
                i--;
            }
            Console.WriteLine("main end");
            Console.ReadLine();
        }
    }
}
