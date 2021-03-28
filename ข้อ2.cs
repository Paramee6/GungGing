using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("enter b");
            int.TryParse(Console.ReadLine(), out b);

            int x = a;
            int y = b;

            while (x != y) 
            {
                if (x<y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine("x="+x);
        }
    }
}
