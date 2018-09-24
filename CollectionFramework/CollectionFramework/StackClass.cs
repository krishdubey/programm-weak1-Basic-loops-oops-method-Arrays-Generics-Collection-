﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class StackClass
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sonoo");
            names.Push("Peter");
            names.Push("James");
            names.Push("Ratan");
            names.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            Console.ReadLine();
        }
        
    }
}
