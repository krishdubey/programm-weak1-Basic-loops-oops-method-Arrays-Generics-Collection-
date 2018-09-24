using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    delegate int Del(int x);
    class Anoynomous
    {
        static void Main(string[] args)
        {
            Del del = delegate(int x)
            {
                Console.WriteLine("This is anonymous method()");
                return x;
            };
           

           int y= del(11);
            Console.WriteLine(y);
            Console.Read();

        }
    }
}
