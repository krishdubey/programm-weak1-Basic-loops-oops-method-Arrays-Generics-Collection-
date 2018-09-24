using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Project1
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 9);
            label:
              switch (n)
              {
                  case 1:
                      Console.WriteLine("It is 10");
                      break;
                  case 2:
                      Console.WriteLine("It is 20");
                      break;
                  case 5:
                      Console.WriteLine("It is 30");
                       continue label;

                  default:
                      Console.WriteLine("Not 10, 20 or 30");
                      break;
              }
          //  Console.WriteLine(n);
            Console.Read();
        }
    }
}
