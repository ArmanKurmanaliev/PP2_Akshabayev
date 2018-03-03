using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G1_Example2
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        [NonSerialized]
        public double gpa;
        public List<Subject> subjects;

        public Student()
        {
            subjects = new List<Subject>();
        }

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            subjects = new List<Subject>();
        }

        public Student(string name, string surname, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
            subjects = new List<Subject>();
        }
    }
}