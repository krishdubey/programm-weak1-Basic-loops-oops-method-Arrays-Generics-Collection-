using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethodsApp2
{
    abstract  class AbsParentClass
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int a , int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void Mul(int x,int y);
        public abstract void Div(int x, int y);
    }
}

