using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Figure>();
            wallList.Add(new Gorizontal(0, mapWidht-2, 0, '+'));
            wallList.Add(new Gorizontal(0, mapWidht-2, mapHeight-1, '+'));
            wallList.Add(new Vertical(0, mapHeight-1, 0, '+'));
            wallList.Add(new Vertical(0, mapHeight-1, mapWidht-2, '+'));
            
        }
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
