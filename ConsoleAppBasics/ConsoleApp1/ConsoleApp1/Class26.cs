﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class26
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= (('A' + 'E') - i); j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
