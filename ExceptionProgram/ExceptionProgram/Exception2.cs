using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class Exception2
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            
            if (b == 0)
            {
                Console.WriteLine("Second Number can not be 0");
                Console.ReadLine();
            }
            else
            {
                c = a / b;
                Console.WriteLine("The Output is:" + c);
                Console.ReadLine();
            }
           
        }
    }
}
