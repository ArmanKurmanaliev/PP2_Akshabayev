using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int x = 0, y = 0;

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("o");

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow)
                    y++;
                if (key.Key == ConsoleKey.UpArrow)
                    y--;
                if (key.Key == ConsoleKey.RightArrow)
                    x++;
                if (key.Key == ConsoleKey.LeftArrow)
                    x--;

                Console.ReadKey();
            }
        }
    }
}
