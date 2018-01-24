using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace far2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
                if (k.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Asdasdlasdkfjh");
                }

                if (k.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Asdasdlasdkfjh");
                }

                if (k.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Asdasdlasdkfjh");
                }

                if (k.Key == ConsoleKey.RightArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Asdasdlasdkfjh");
                }

                if (k.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                }

                if (k.Key == ConsoleKey.Escape)
                    break;
            }

            
        }
    }
}
