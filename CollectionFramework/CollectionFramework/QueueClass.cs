using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class QueueClass
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Krishna");
            names.Enqueue("Jay");
            names.Enqueue("Janmejay");
            names.Enqueue("Ratan");
            names.Enqueue("Faran");
            names.Enqueue("Faran");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
            Console.ReadLine();
        }
    }
}
