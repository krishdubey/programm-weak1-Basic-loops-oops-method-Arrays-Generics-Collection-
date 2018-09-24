using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class Sample1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two Numbers:");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum is:" + c);
            Console.Read();
        }
    }
}
