using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2.constructors
{
    class DefaultConst
    {
        int id;
        string name;
        string address;
        int age;

        public void DisplayData()
        {
            Console.WriteLine("age is:" + age);
            Console.WriteLine("name is:"+ name);
            Console.WriteLine("address is:" + address);
            Console.WriteLine("age is:" + age);

        }
    }
    class DefaultUse
    {
        static void Main(string[] args)
        {
            DefaultConst obj1 = new DefaultConst();
            obj1.DisplayData();
            Console.Read();
                
        }
    }
}
