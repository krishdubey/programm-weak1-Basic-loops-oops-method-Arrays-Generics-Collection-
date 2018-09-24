using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class ClassTryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value");
            try
            {
                int a, b, c;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient is:" + c);
            }
            catch
            {
                Console.WriteLine("Error Occured");
            }
            finally
            {
                Console.WriteLine("COde is Executed");
            }

            Console.ReadLine();
        }
    }
}
