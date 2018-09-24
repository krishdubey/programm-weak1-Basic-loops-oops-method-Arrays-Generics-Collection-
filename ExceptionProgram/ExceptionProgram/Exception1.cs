using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class Exception1
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a / b;
            
            Console.WriteLine("The Output is:" + c);
            Console.ReadLine();
        }
    }
}
