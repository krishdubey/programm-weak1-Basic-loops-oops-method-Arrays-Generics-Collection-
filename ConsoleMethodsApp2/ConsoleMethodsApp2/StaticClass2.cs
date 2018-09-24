using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
   public class StaticClass2
    {
        public int accno;
        public string name;
        public static float rateOfInterest = 8.8f;

        public StaticClass2(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void DisplayData()
        {
            Console.WriteLine("Account no:" + this.accno);
            Console.WriteLine("Name is:" + this.name);
            Console.WriteLine("Rate of Interest is:" + rateOfInterest);

        }
    }

    class TestAccount1
    {
        static void Main(string[] args)
        {
            StaticClass2.rateOfInterest = 10.5f;
            StaticClass2 obj1 = new StaticClass2(1, "krishna");
            StaticClass2 obj2 = new StaticClass2(2, "Ankur");
            obj1.DisplayData();
            obj2.DisplayData();
            Console.Read();
        }
    }
}
