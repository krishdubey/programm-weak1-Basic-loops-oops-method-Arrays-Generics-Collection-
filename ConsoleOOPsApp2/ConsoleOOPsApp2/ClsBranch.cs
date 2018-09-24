using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClsBranch
    {
        int Bcode;
        string BName;
        string BAddress;

        public void GetBranchData()
        {
            Console.WriteLine("Enter branch detail:");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            this.BName = Console.ReadLine();
            this.BAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("Branch Details are:");
            Console.WriteLine("Bcode Code is :" + this.Bcode);
            Console.WriteLine("BName is:" + this.BName);
            Console.WriteLine("BAddress is:" + this.BAddress);
        }
    }

    class ClsEmployee5 : ClsBranch
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public void GetEmpData()
        {
            Console.WriteLine("Enter Emp Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.EAge = Convert.ToInt32(Console.ReadLine());

        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Emp Details are:");
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("EAddress is:" + this.EAddress);
            Console.WriteLine("EAge is:" + this.EAge);
        }

    }
    class ClsInheritance
    {
        static void Main(string[] args)
        {
            ClsEmployee5 obj1 = new ClsEmployee5();
            obj1.GetBranchData();
            obj1.GetEmpData();
            obj1.DisplayBranchData();
            obj1.DisplayEmpData();
            Console.Read();

        }
    }
}
