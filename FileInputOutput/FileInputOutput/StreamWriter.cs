﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutputExample
{
    class StreamWriter1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello c#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
            Console.Read();
        }
    }
}
