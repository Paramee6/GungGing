using System;

public class Program
{
    public static void Main()
    {
        string[] recentFileArray = new string[5] { "", "", "", "", "" };


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter File name : ");
            string RecentFile = Console.ReadLine();

            recentFileArray[i] = RecentFile;
        }


        {
            Console.WriteLine("Please input a number from 0-3 to choose the following menu : ");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new file");
            Console.WriteLine("[2] Open recent file");
            Console.WriteLine("[3] Exit");
            int answer;
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 0:
                    for (int i = 0; i < recentFileArray.Length; i++)
                    {
                        Console.WriteLine("ID : " + i + " File : " + recentFileArray[i]);
                    }
                    break;



            }
        }
    }
}



