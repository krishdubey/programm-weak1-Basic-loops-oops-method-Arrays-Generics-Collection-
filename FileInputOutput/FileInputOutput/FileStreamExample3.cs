using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class FileStreamExample3
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.ReadLine();
        }
    }
}
