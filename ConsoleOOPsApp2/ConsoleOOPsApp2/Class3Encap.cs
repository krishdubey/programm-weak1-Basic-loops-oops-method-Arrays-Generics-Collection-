using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPsApp2
{
    class Class3Encap
    {
        int Id;
        string Name;
        string Address;
        int Age;

        public void Get()
        {
            Console.WriteLine("Enter Details");
            this.Id = Convert.ToInt32(Console.ReadLine());
            this.Name = Console.ReadLine();
            this.Address = Console.ReadLine();
            this.Age = Convert.ToInt32(Console.ReadLine());


        }
        public void Display()
        {
            Console.WriteLine("show detail");
            Console.WriteLine("Id is:" + this.Id);
            Console.WriteLine("Name is:" + this.Name);
            Console.WriteLine("Address is:" + this.Address);
            Console.WriteLine("Age is:" + this.Age);
        }
    }

    class Usesed
    {
        static void Main(string[] args)
        {
            Class3Encap obj1 = new Class3Encap();
            obj1.Get();
            obj1.Display();
            Console.Read();
        }
    }
}
