using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class33
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=(6-i);j++)
                {
                    Console.Write((6-i));
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
