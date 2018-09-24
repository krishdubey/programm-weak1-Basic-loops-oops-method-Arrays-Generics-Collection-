using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class SingleDimensionalArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine("Elements of Array are:");
            for(int i=0;i<4;i++)
            {
                Console.Write(A[i] + ", ");
            }
            Console.Read();
        }
    }
}
