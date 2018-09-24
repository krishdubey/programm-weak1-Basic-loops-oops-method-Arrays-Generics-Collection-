using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class FileStreamExample
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\a.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();
            Console.Read();
        }
    }
}
