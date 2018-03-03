using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Snake
    {
        List<Point> body;
        public string sign;
        public ConsoleColor color;
        public int cnt;
        public Snake()
        {
            cnt = 0;
            sign = "o";
            body = new List<Point>();
            body.Add(new Point(10, 10));
            color = ConsoleColor.Yellow;
        }

        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');

            cnt++;
            if (cnt % 20 == 0)
                body.Add(new Point(0, 0));

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x < 0)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x >= Console.WindowWidth)
                body[0].x = 0;
            if (body[0].y < 0)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y >= Console.WindowHeight)
                body[0].y = 0;
        }

        public bool CollisionWallandSnake(List<Point> body1)
        {
            bool answer = false;
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    answer = true;
            }
            for (int i = 1; i < body1.Count; i++)
            {
                if (body[0].x == body1[i].x && body[0].y == body1[i].y)
                    answer = true;
            }
            return answer;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }

    }
}