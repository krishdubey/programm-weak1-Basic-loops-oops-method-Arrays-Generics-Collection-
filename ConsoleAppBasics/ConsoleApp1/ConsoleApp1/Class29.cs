﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class29
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=5; i++)
            {
                for (int j = 1; j <= (5 - i); j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
