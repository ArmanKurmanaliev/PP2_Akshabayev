using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w34second
{
    class Program
    {
        static int ConSize = 25;
        static void ShowDir(DirectoryInfo dir, int cursor, int zero)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            FileSystemInfo[] FileS = dir.GetFileSystemInfos();
            int index = 0;
            foreach (FileSystemInfo f in FileS)
            {
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }

                else if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (index >= zero && index <= zero + ConSize)
                    Console.WriteLine(f.Name);

                index++;
            }
        }


        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            int zero = 0;
            int cursor = 0;
            ShowDir(dir, cursor, zero);
            int n = dir.GetFileSystemInfos().Length;

            while (true)
            {
                try
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        cursor++;
                        if (cursor == n)
                        {
                            cursor = 0;
                            zero = 0;
                        }

                        if (cursor > zero + ConSize)
                        {
                            zero++;
                        }
                    }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        cursor--;
                        if (cursor < 0)
                        {
                            cursor = n - 1;
                            zero = cursor - ConSize;
                        }
                        if (cursor < zero)
                        {
                            zero--;
                        }
                    }

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (dir.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            dir = (DirectoryInfo)dir.GetFileSystemInfos()[cursor];
                            cursor = 0;
                            n = dir.GetFileSystemInfos().Length;
                            zero = 0;
                        }

                        else
                        {
                            StreamReader sr = new StreamReader(dir.GetFileSystemInfos()[cursor].FullName);
                            string s = sr.ReadToEnd();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine(s);
                            Console.ReadKey();
                        }
                    }

                    if (key.Key == ConsoleKey.Escape)
                    {
                        if (dir.Parent != null)
                        {
                            dir = dir.Parent;
                            cursor = 0;
                            n = dir.GetFileSystemInfos().Length;
                            zero = 0;
                        }
                        else
                            break;
                    }
                    ShowDir(dir, cursor, zero);
                }
                catch (Exception e)
                {
                    Console.WriteLine("FATAL");
                    Console.ReadKey();
                }
            }
        }
    }
}
