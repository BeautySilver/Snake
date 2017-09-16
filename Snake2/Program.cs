using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        public static int max_x = 80;
        public static int max_y = 25;

        static void Main(string[] args)
        {
          
            Console.SetBufferSize(max_x, max_y);
            Walls walls = new Walls(max_x, max_y);
            walls.Draw();
           

            Point p = new Point(4, 5, '*');           
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(77, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while(true)
            {
                if(walls.IsHit(snake)|| snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw(); 
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }                                
            }
           
           

            
        }
        
    }
}
