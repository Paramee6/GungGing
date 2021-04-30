using System;

namespace ข้อ1
{
    class Program
    {
        static viod Main(string[] args)
        {
            int rows, b, i, j;
            int a = 1;
            Console.Write("Insert row : ");
            rows = int.Parse(Console.Readline());

            if (rows >= 0)
            {
                for (i = 0; i < rows; i++)
                {
                    for (i = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                        {
                            a = 1;
                        }                       
                        else
                        {
                            a = a * (i - j + 1) / j;
                            Console.Write(a + " ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal's Triangle rows number");                 
            }
            Console.Readline();
        }
    }
}