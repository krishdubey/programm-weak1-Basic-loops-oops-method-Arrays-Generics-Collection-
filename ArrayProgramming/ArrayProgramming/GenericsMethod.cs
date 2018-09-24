using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class GenericsMethod
    {
        static void Display<G>(G s)
        {
            Console.WriteLine("Value of S is:" + s);
        }

        static void Main(string[] args)
        {
            Display<int>(100);
            Display<string>("krishna");
            Display<double>(45.5);

            Console.Read();
        }
        
    }
}
