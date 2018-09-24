using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    public class StaticClass3
    {
        public int accno;
        public string name;
        public static int count = 0;

        public StaticClass3(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void Display()
        {
            Console.WriteLine("name is:" + this.name);
            Console.WriteLine("accno is:" + this.accno);
        }
    }
    class testAccount3
    {
        static void Main(string[] args)
        {
            StaticClass3 o1 = new StaticClass3(101, "krishna");
            StaticClass3 o2 = new StaticClass3(102, "Ankur");
            StaticClass3 o3 = new StaticClass3(103, "anji");
            o1.Display();
            o2.Display();
            o3.Display();
            Console.WriteLine("Count is:" + StaticClass3.count);
            Console.Read();
        }
    }
}
