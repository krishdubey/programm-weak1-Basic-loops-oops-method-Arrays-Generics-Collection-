using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class16
    {
         static void main(String[] args)
        {
            Console.WriteLine("main begin");

            for (int i = 1, j = 50, k = 100; i <= 10 && j >= 1 && k >= 90; i++, j -= 4, k -= 2, i += 2)
                      
            {
                Console.WriteLine("loop body:" + i + "," + j + "," + k);

            }

            Console.WriteLine("main-end:");
        }
    }
}
