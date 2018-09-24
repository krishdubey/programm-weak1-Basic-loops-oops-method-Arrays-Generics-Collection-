using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            int i = 1;
            while (i++ < 5) ;
            Console.WriteLine("loop bdy:"+ ++i);
            Console.WriteLine("loop body end:" + i);
            i++;
            Console.WriteLine("main end:" + i);
            Console.Read();
        }
    }
}
