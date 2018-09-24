using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Printing number from 1 to 10");
            do
            {
                count = count + 1;
                Console.WriteLine(count);

            }
            while (count < 10);
            Console.ReadLine();
        }
    }
}
