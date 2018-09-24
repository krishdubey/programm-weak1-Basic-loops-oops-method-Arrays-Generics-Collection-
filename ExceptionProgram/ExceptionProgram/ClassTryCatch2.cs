using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class ClassTryCatch2
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
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("COde is Executed");
            }

            Console.ReadLine();
        }
      
    }
}
