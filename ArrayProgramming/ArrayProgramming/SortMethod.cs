using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class SortMethod
    {
        static void Main(string[] args)
        {
            int[] A = new int[8] { 10, 5, 8, 6, 12, 4, 2, 15 };
            Console.WriteLine("before Sorting Array Element");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Array.Sort(A);
            Console.WriteLine("\n After Sorting The Element:");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.Read();
        }
    }
}
