using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class CopyArrays
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 10, 20, 30, 40,50};
            int[] B = new int[10] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            Console.WriteLine("Element of Array A are:");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\nElement of Array B are");
            
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write(B[i] + " ");
                }
            A.CopyTo(B,2);
            Console.WriteLine("\n Elements of B After Copy");
            for(int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.Read();
        }
    }
}
