using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class21
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (char j = 'A'; j <= 'E'; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
