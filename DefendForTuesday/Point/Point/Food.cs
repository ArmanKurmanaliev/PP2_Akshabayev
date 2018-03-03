using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Food
    {
        public Point location;
        public int x, y;
        public ConsoleColor Color;
        public string sign;

        public Food()
        {
            Color = ConsoleColor.Cyan;
            sign = "$";
            location = new Point(x, y);
        }

        public void Random()
        {
            x = new Random().Next(1, 65);
            y = new Random().Next(1, 19);
            location = new Point(x, y);
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.Write(sign);
        }
    }
}
