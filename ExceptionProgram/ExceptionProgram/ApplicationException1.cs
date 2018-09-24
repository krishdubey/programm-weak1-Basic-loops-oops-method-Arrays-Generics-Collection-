using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class ApplicationException1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int y = int.Parse(Console.ReadLine());
            if(y%2 > 0)
            {
                throw new ApplicationException("Divisor value can not be odd number");
            }
            int z = x / y;
            Console.WriteLine("The result is: " + z);
            Console.WriteLine("End of the Program.");
            Console.ReadLine();
        } 
    }
}
