using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Student
    {
        public string name;
        public int age;
        public double gpa;

        public Student(string n, int a, double g)
        {
            name = n;
            age = a;
            gpa = g;
        }

        public override string ToString()
        {
            return name + " " + age + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("ddk", 12, 3.6);
            Console.WriteLine(s);
            Student x = new Student("exe", 19, 2.5);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
