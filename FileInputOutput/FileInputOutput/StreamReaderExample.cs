using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class StreamReaderExample
    {
        static void Main(string[] args)
        {
            
                FileStream f = new FileStream("g:\\output.txt", FileMode.OpenOrCreate);
                StreamReader s = new StreamReader(f);

                string line = s.ReadLine();
                Console.WriteLine(line);

                s.Close();
                f.Close();
            Console.ReadLine();
            
        }
    }
}
