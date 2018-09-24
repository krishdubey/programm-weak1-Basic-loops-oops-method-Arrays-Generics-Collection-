using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Recursive
    {
        public int factR(int n)
        {
            int result;
            if (n == 1)
                return 1;
            result = factR(n - 1) * n;
            return result;
        }
          static void Main(string[] args)
            {
                Recursive r1 = new Recursive();
            
            int a = 1;

            while (a != 0)
            {
                Console.WriteLine("Enter Value of No");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("factorial of " + no + " is:" + r1.factR(no));
                Console.WriteLine("if we wantto exit press 0 other wise any number");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("thsanks to visit please enter to exit");
            Console.Read();
            }
        
        }
    
    }

