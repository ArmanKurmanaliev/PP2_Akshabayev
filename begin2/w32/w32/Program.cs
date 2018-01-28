using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w32
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("UpArrow");
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("down");
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Left");
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Right");
                }

                if (key.Key == ConsoleKey.Enter)
                    Console.Clear();

                if (key.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
