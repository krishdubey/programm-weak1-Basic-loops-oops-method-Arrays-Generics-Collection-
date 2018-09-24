using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClassFunctionOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Add(float x, int y)
        {
            return x + y;
        }
        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            ClassFunctionOverloading obj1 = new ClassFunctionOverloading();

            Console.WriteLine("sum is:" + obj1.Add(10, 20));
            Console.WriteLine("sum is:" + obj1.Add(10.5f, 20));
            Console.WriteLine("sum is:" + obj1.Add(10.8f, 20.2f,40.8f));
            Console.Read();
        }
    }

}
