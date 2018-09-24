using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<5;i++)
            {
                for(int j=1;j<5;j++)
                {
                    Console.WriteLine(i + " " + j);
                    if (j >= 3)
                    {
                        Console.WriteLine("Not execute");
                        break;
                    }
                }
               
            }
            Console.Read();
        }
    }
}
