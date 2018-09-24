using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class Anonymous2
    {
        public delegate void Print(int value);

        public static void Main()
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value:" + val);
            };

            print(100);
            Console.Read();
        }
    }
}
