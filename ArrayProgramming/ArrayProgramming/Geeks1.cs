using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgramming
{
    class Geeks1
    {
     static void alternateSort(int[] arr, int n)
        {
            Array.Sort(arr);
            int i = 0, j = n - 1;
            while(i < j)
            {
                Console.Write(arr[j--] + " ");
                Console.Write(arr[i++] + " ");
            }
            if (n % 2 != 0)
                Console.WriteLine(arr[i]);
            Console.Read();
        }
        static void Main(string[] args)
        {
            int[] arr = { 7,1,2,3,4,5,6};
            int n = arr.Length;
            alternateSort(arr, n);
        }
    }
}
