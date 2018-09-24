using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class27
    {
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'E'; j >= (('A' + 'E') - i); j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
