using System;

namespace test_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
		   float x, y, dx, dy, step;
		   float x1, x2, y1, y2;
			Console.WriteLine("input x1 : ");
			x1 = float.Parse(Console.ReadLine());
		    Console.WriteLine("input x2 : ");
			x2 = float.Parse(Console.ReadLine());
			Console.WriteLine("input y1 : ");
			y1 = float.Parse(Console.ReadLine());
			Console.WriteLine("input y2 : ");
			y2 = float.Parse(Console.ReadLine());
			
			 dx = x2 - x1;
			 dy = y2 - y1;
			if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;


                }
                Console.WriteLine("END");

            }
            else
            {
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;

                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;


                }
                Console.WriteLine("END");
			}
		}
	}
}
	