using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    class AbsChild : AbsParentClass
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main(string[] args)
        {
            AbsChild obj1 = new AbsChild();
            obj1.Add(10,20);
            obj1.Sub(20, 10);
            obj1.Mul(10, 20);
            obj1.Div(20, 10);
            Console.Read();
        }
    }
}
