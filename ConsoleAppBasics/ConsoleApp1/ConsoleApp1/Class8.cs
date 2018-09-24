using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main begin");
            int i = 1;
            loop1:
            while (i <= 5)
            {
                Console.WriteLine("loop begin:" + i++);
                int j = 10;
                abc:

                while (j <= 13)
                {



                    Console.WriteLine("inner loop begin:" + i + "," + j);
                    if (j == 11)
                    {
                        j++;
                        goto abc;
                    }
                    Console.WriteLine("inner loop end:" + i + "," + j);
                    j++;
                }
                Console.WriteLine("loop end:" + i);
                i++;
            }
            Console.WriteLine("main end" + i);
        }
    }
}

