using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    public class StaticClass1
    {
        public int accno;
        public string name;
        public static float rateOfInterest = 8.8f;
        public StaticClass1(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }

    class TestAccount
    {
        public static void Main(string[] args)
        {
            StaticClass1 a1 = new StaticClass1(101, "Sonoo");
            StaticClass1 a2 = new StaticClass1(102, "Mahesh");
            a1.display();
            a2.display();
            Console.Read();

        }
    }
}

