using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class ReverseMethod
    {
        static void Main(string[] args)
        {
            int[] A = new int[8] { 10, 5, 8, 6, 12, 4, 2, 1 };
            Console.WriteLine("before Sorting Array Element");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            //Array.Reverse(A);
            Array.Reverse(A, 2, 4);
            Console.WriteLine("\n After Reversing The Element:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.Read();
        }
    }
}
