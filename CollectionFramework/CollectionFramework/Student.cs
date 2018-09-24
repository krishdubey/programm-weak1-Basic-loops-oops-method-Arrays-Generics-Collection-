using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    class Student:IComparable<Student>
    {
        internal static object sort;

        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    class CompareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Sid = 103, Name = "C", Class = 10, Marks = 59.5f };
            Student s2 = new Student { Sid = 105, Name = "E", Class = 10, Marks = 52.5f };
            Student s3 = new Student { Sid = 104, Name = "D", Class = 10, Marks = 58.5f };
            Student s4 = new Student { Sid = 106, Name = "F", Class = 10, Marks = 54.5f };
            Student s5 = new Student { Sid = 101, Name = "A", Class = 10, Marks = 51.5f };
            Student s6 = new Student { Sid = 102, Name = "B", Class = 10, Marks = 55.5f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };

            CompareStudent obj = new CompareStudent();
            Students.Sort(obj);
            //Students.Sort(1, 4, obj);
            foreach (Student S in Students)
               Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
            Console.ReadLine();
        }
       
    
    }
}
