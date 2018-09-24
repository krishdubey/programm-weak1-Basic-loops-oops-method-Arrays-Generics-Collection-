using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInputOutput
{
    class TextReaderExample1
    {
        static void Main(string[] args)
        {
           
                using (TextReader tr = File.OpenText("g:\\f.txt"))
                {
                    Console.WriteLine(tr.ReadToEnd());
               // Console.WriteLine(tr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
