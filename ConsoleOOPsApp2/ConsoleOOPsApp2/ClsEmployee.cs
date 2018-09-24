using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClsEmployee
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
                Console.WriteLine("Employee Details:");
                Console.WriteLine("EmpId is:" + this.EmpId);
                Console.WriteLine("EName is:" + this.EName);
                Console.WriteLine("EAddress is:" + this.EAddress);
                Console.WriteLine("EAge is:" + this.EAge);
            }
        
    }

    class ClsEncapsulate
    {
        static void Main(string[] args)
        {
            ClsEmployee obj1 = new ClsEmployee();
            int n = 1;
            while (n != 0)
            {
                obj1.GetData();
                obj1.DisplayData();
                Console.WriteLine("if want to exit enter 0 otherwise any number");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thanks to visit please enter to exit");
            Console.Read();
        }
    }
}
 