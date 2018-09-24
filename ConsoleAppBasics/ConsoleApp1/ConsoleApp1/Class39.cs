using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class39
    {
        
        static void Main(string[] args)
        {
            
            for (int i = 1;i<=5;i++)
            {
                for(int j = 1; j<=(5-i); j++)
                {
                    Console.Write(" ");
                }
                char ch = 'A';
                for (int j=1; j<=((2*i) - 1); j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
