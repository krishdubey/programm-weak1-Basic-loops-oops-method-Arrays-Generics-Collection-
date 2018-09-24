using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[6] { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Element of Arrays are:");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n Enter New Size Of Arrays:");
            int n = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref A, n);
            Console.WriteLine("\nElement of after resize");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Lengthof Array is:- " + A.Length);
            Console.WriteLine("Rank of Array is:-" + A.Rank);
            Console.Read();

        }
    }

    }

