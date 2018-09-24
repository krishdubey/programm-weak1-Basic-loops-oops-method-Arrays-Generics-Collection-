using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClassFunctionOverriding
    {
        protected int EmpId;
        protected string EName;
        string EAddress;
        int EAge;
        public virtual void GetEmpData()
        {
            Console.WriteLine("Enter Emp Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Emp Details are:");
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("EAddress is:" + this.EAddress);
            Console.WriteLine("EAge is:" + this.EAge);


        }

    }
    class ClsManager : ClassFunctionOverriding
    {
        double CA, Bonus;

        public override void GetEmpData()
        {
            Console.WriteLine("Enter Manager Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.CA = Convert.ToInt32(Console.ReadLine());
            this.Bonus = Convert.ToInt32(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("Emp Details are:");
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("CA is:" + this.CA);
            Console.WriteLine("Bonus   is:" + this.Bonus);
        }
    }

    class Functionoverriding
    {
        static void Main(string[] args)
        {
            ClassFunctionOverriding obj1 = new ClassFunctionOverriding();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
            Console.Read();
        }
    }
}
