using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class StringWriter1
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint \n" +
                "It is nice site. \n" +
                "It provides technical tutorials";
            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();
            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);
            // Writing data using StringWriter  
            writer.WriteLine(text);
          writer.Flush();// clear the buffer & jo hum bhejenge wo  usme put kr dega
            // Closing writer connection  
            writer.Close();
            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());
            // Reading data  
            while (reader.Peek() > -1)// It is used to return the next available character but does not consume it.

            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.Read();
        }
    }
}
