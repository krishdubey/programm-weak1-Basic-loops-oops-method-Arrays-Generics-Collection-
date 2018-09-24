using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class9
    {

        public static void main(String[] args)
        {
            Console.WriteLine("main begin");
        outer:
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("outer loop begin:" + i);
            abc:
                for (int j = 10; j <= 13; j++)
                {

                    Console.WriteLine("inner loop begin:" + i + "," + j);
                    if (j == 11)
                    {
                        goto outer;
                    }
                    Console.WriteLine("inner loop end:" + i + "," + j);
                }
                Console.WriteLine("outer loop end:" + i);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("main end");
        }
    }
}
