using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class JngagedArray
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[4] {1,2,3,4 };
            A[1] = new int[2] { 5, 6 };
            A[2] = new int[3] { 7, 8, 9 };
            {
                Console.WriteLine("The Arrays Element are:");
                for(int i=0;i<A.Length;i++)
                {
                    for(int j = 0; j < A[i].Length;j++ )
                    {
                        Console.Write(A[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.Read();
            }
        }
    }
}
