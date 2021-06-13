using System;

public class BasicInputOutput
{
    public static void Main(string[] args)
    {
        int[,] number = new int[3, 3];
        int answer = 0;
        bool isAvailable = false;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int.TryParse(Console.ReadLine(), out number[i, j]);
            }
        }

        Console.WriteLine("\nEnter Your Number : ");
        int.TryParse(Console.ReadLine(), out answer);

        Console.WriteLine("\nBefore : ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(number[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (number[i, j] == 0)
                {
                    if (number[0, j] != answer && number[1, j] != answer && number[2, j] != answer && number[i, 0] != answer && number[i, 1] != answer && number[i, 2] != answer)
                    {
                        number[i, j] = answer;
                    }
                    else
                    {
                        isAvailable = true;
                    }
                }
            }
        }


        Console.WriteLine("\nAfter : ");
        if (!isAvailable)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(number[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number is available");
        }


    }
}