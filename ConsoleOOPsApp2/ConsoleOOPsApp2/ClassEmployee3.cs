using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClassEmployee3
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public ClassEmployee3()
        {
            this.EmpId = 100;
            this.EName = "Krishna";
            this.EAddress = "Bizreutime";
            this.EAge = 20;

        }
        public ClassEmployee3(ClassEmployee3 obj)
        {
            this.EmpId = obj.EmpId;
            this.EName = obj.EName;
            this.EAddress = obj.EAddress;
            this.EAge = obj.EAge;
        }
        public void DisplayData()
        {
            Console.WriteLine("Id is:" + this.EmpId);
            Console.WriteLine("name is:" + this.EName);
            Console.WriteLine("address is:" + this.EAddress);
            Console.WriteLine("age is:" + this.EAge);

        }

    }
    class CopyCons
    {
        static void Main(string[] args)
        {
            ClassEmployee3 obj = new ClassEmployee3();
            ClassEmployee3 obj1 = new ClassEmployee3(obj);
            obj.DisplayData();
            obj1.DisplayData();
            Console.Read();


           
        }
    }
}
