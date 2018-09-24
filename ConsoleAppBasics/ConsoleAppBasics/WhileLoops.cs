using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Printing number from 1 to 10");
            while(count<10)
            {
                count = count + 1;
                Console.WriteLine(count);

            }
            Console.ReadLine();
        }
    }
}
