using System;

public class Test
{
	public static void Main()
	{
		int userInput = Convert.ToInt32(Console.ReadLine());
		
		if(userInput > 0)
		{
			int temp = 1;
			
			for(int i = 1; i <= userInput; i++){
				temp = temp * i;
			}
			Console.WriteLine("{0}",temp);
			Console.ReadLine();
		}
		else 
		{
			Console.WriteLine("Input should be greater than zero");
			Console.ReadLine();
		}
	}
}
