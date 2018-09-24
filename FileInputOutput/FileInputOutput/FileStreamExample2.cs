using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class FileStreamExample2
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\b.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
            Console.WriteLine("Create success");
            Console.Read();
        }
    }
}
