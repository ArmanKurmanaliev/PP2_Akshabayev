using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classss
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
            Student s = new Student ("Arman", 18, 1.25);
            Console.WriteLine(s + "\n");

            Student w = new Student("Asyl", 18, 3.5);
            Console.WriteLine(w);

            Console.ReadKey();
        }
    }
}