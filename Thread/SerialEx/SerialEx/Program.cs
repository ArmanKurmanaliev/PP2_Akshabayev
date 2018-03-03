using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace W4G1_Example2
{
    class Program
    {
        static void F1()
        {
            StreamWriter sw = new StreamWriter("student.txt");
            try
            {
                Student a = new Student("aaa", "bbb");
                a.gpa = 3.2;
                sw.WriteLine(a.name);
                sw.WriteLine(a.surname);
                sw.WriteLine(a.gpa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sw.Close();
            }

        }
        static void F2()
        {
            StreamReader sr = new StreamReader("student.txt");
            string name = sr.ReadLine();
            string surname = sr.ReadLine();
            double gpa = double.Parse(sr.ReadLine());
            Student b = new Student(name, surname, gpa);
            Console.WriteLine(b.name);
            Console.WriteLine(b.surname);
            Console.WriteLine(b.gpa);
            Console.ReadKey();
        }

        static void F3()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Student a = new Student("aaa", "bbb", 3.2);
            a.subjects.Add(new Subject("PP1"));
            a.subjects.Add(new Subject("Algorithms and Data Structures"));
            a.subjects.Add(new Subject("OOP"));

            xs.Serialize(fs, a);
            fs.Close();
        }

        static void F4()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = xs.Deserialize(fs) as Student;
            Console.WriteLine(b.subjects[1].name);
            Console.ReadKey();
        }

        static void F5()
        {
            Student a = new Student("aaa", "bbb", 3.2);
            a.subjects.Add(new Subject("PP1"));
            a.subjects.Add(new Subject("Algorithms and Data Structures"));
            a.subjects.Add(new Subject("OOP"));

            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, a);
            fs.Close();
        }

        static void F6()
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Student b = bf.Deserialize(fs) as Student;
        }
        static void Main(string[] args)
        {
            F2();
        }
    }
}