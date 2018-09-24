using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class ClassEmployee2
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        private ClassEmployee2(int Id, string s1, string s2, int Ag)
        {
            this.EmpId = Id;
            this.EName = s1;
            this.EAddress = s2;
            this.EAge = Ag;
        }

        public void DisplayData()
        {
            Console.WriteLine("age is:" + this.EmpId);
            Console.WriteLine("name is:" + this.EName);
            Console.WriteLine("address is:" + this.EAddress);
            Console.WriteLine("age is:" + this.EAge);

        }
    
        static void Main(string[] args)
        {
            ClassEmployee2 obj2 = new ClassEmployee2(1, "kri", "v", 22);
            obj2.DisplayData();
            Console.Read();
        }
    }
}
