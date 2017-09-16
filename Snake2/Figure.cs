using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Figure
    {
       protected List<Point> pList;
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            for (var i = 0; i < pList.Count; i++)
            {
                if(figure.IsHit(pList[i])) return true;
            }
            return false;
        }
        public bool IsHit(Point point)
        {
            for (var i = 0; i < pList.Count; i++)
            {
                if (pList[i].IsHit(point)) return true;
            }
            return false;
        }
        
    }
   
}
