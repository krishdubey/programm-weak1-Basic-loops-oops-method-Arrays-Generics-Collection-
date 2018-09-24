using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class TextWriterExample1
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("g:\\f.txt"))
            {
                writer.WriteLine("HEllo BizrunTime");
                writer.WriteLine("C# File Handling From Krishna");

            }
            Console.WriteLine("Data written successfully");
            Console.ReadLine();
        }
    }
}
