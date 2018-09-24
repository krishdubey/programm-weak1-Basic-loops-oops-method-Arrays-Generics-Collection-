using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class22
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
