using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class SortedSetClass
    {
        public static void Main(string[] args)
        {

            SortedSet<string> obj1 = new SortedSet<string>();
            obj1.Add("Sonoo");
            obj1.Add("Ankit");
            obj1.Add("Peter");
            obj1.Add("Irfan");
            obj1.Add("Ankit");//will not be added  

            // Iterate SortedSet elements using foreach loop  
            foreach (string obj in obj1)
            {
                Console.WriteLine(obj);

            }
            Console.ReadLine();
        }
    }
}
