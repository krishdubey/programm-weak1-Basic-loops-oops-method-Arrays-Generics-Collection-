using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class Class1
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
    class EmpUses1
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            for (int i = 0; i <= 5; i++)
            {
                obj1.GetData();
                obj1.DisplayData();
            }
            Console.Read();
        }
    }
}
