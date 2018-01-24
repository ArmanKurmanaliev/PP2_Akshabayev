using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace far
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\");
            
            DirectoryInfo[] ds = directory.GetDirectories();
            FileInfo[] fs = directory.GetFiles();

            foreach (DirectoryInfo d in ds)
                Console.WriteLine(d.Name);
            foreach (FileInfo f in fs)
                Console.WriteLine(f.Name);

            Console.ReadKey();
            

            /*
            FileSystemInfo[] fss = directory.GetFileSystemInfos();

            foreach (FileSystemInfo a in fss)
                Console.WriteLine(a.Name);

            Console.ReadKey();
            */
        }
    }
}
