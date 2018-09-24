using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class CopyMethod2
    {
        static void Main(string[] args)
        {
            int[] A = new int[6] { 10, 20, 30, 40, 50, 60};
            int[] B = new int[8] { 70, 80, 90, 100, 110, 120, 130, 140 };
            Console.WriteLine("Element of A Array are:");
            for(int i=0; i<A.Length;i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\nElement of B Array are:");
            for(int i=0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            // Array.Copy(A, B, 3);
            Array.Copy(A, 2, B, 3, 4);
            Console.WriteLine("\nElement after Copy Method:");
            for(int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.Read();
        }
    }
}
