using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2.constructors
{
   public class ClassConstru1
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public ClassConstru1()
        {
            this.EmpId = 100;
            this.EName = "Krishna";
            this.EAddress = "Bizreutime";
            this.EAge = 20;

        }
        public void DisplayData()
        {
            Console.WriteLine("EmpId is:" + this.EmpId);
            Console.WriteLine("EName is:" + this.EName);
            Console.WriteLine("EAddress is:" + this.EAddress);
            Console.WriteLine("EAge is:" + this.EAge);
        }

    }

    
}