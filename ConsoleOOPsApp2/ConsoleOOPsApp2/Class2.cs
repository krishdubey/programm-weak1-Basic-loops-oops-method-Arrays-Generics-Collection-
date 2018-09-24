using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class Class2
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public void GetData()
        {
            Console.WriteLine("Enter Details");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData()
        {
            Console.WriteLine("The Given Data Is");
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("EAddress is:" + this.EAddress);
            Console.WriteLine("EAge is:" + this.EAge);
        }
    }
    class EmpUses2
    {
        static void Main(string[] args)
        {
            Class2 obj1 = new Class2();
               obj1.GetData();
                obj1.DisplayData();
            Class2 obj2 = new Class2();
            obj2.GetData();
            obj2.DisplayData();
            Console.Read();
        }
    }
}

