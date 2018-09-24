using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class ArrayInputFromConsol
    {
        public static void Main()

        {
            int i, j;
            int[,] arr = new int[3, 3];
            System.Console.WriteLine("This is 3 X 3 Array");

            for ( i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                   
                    Console.Write("Array is: [{0},{1}] :" , i , j );
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n the output Array is:");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
