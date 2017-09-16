using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x,int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset,Direction direction)
        {
            if(direction==Direction.Right)
            {
                x += offset;
            }
            if(direction==Direction.Left)
            {
                x -= offset;
            }
             if(direction==Direction.Up)
            {
                y -= offset;
            }
             if(direction==Direction.Down)
            {
                y += offset;
            }
            if (x >= Console.BufferWidth) x = 0;
            if (x < 0) x = Console.BufferWidth - 1;
            if (y >= Console.BufferHeight) y = 0;
            if (y < 0) y = Console.BufferHeight - 1;

        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
