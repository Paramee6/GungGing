using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
			bool gameStart=true; 
			Console.WriteLine("Enter box1");
            int box1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter box2");
            int box2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter box3");
            int box3 = int.Parse(Console.ReadLine());
			
			while (gameStart==true)
			{
			Console.WriteLine("A Choose box");
			Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
            int A_box = int.Parse(Console.ReadLine());
			Console.WriteLine("A Enter amount");
			int A_amount = int.Parse(Console.ReadLine()); 
				
			switch(A_box) {
				case 1 : box1 = box1 - A_amount;
				break;
				case 2 : box2 = box2 - A_amount;
				break;
				case 3 : box3 = box3 - A_amount;
				break;
				default :
				Console.WriteLine("Error");
				break;
				}
			 if (box1 <= 0 & box2 <= 0 & box3 <= 0) 
			 {
				Console.WriteLine("B is Winner");
				 gameStart = false;		
				 return;
		     }
			
				Console.WriteLine("B Choose box");
			Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
            int B_box = int.Parse(Console.ReadLine());
			Console.WriteLine("B Enter amount");
			int B_amount = int.Parse(Console.ReadLine()); 
				
			switch(B_box) {
				case 1 : box1 = box1 - B_amount;
				break;
				case 2 : box2 = box2 - B_amount;
				break;
				case 3 : box3 = box3 - B_amount;
				break;
				default :
				Console.WriteLine("Error");
				break;
				}
			if (box1 <= 0 & box2 <= 0 & box3 <= 0) 
			 {
				Console.WriteLine("A is Winner");
				gameStart = false;	
				return;
		     }
          }
		}
	}
}
