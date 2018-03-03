using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;    

namespace Serialization
{
    class Program
    {
        static void F1()
        {
            FileStream fs = new FileStream(@"dat2.ser", FileMode.Create, FileAccess.ReadWrite);

            Student s = new Student("Askar", 30);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

            Console.WriteLine("done");
        }


        static void F2()
        {
            FileStream fs = new FileStream(@"dat2.ser", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Student s = bf.Deserialize(fs) as Student;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        static void Main(string[] args)
        {
            F2();
            Console.ReadKey();
        }
    }
}
