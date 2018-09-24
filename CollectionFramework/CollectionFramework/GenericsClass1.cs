using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class GenericsClass1
    {
        public bool Compare(int a, int b)
        {
            if (a == b)
                return true;
            return false;
        }
        public bool Compare(float a, float b)
        {
            if (a == b)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            GenericsClass1 obj = new GenericsClass1();
            bool result = obj.Compare(10, 10);
            bool result1 = obj.Compare(10.5f, 0.5f);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadLine();
        }
    }
}
