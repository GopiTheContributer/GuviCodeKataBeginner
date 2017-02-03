using System;

class Ideone
{
	public static void Main (string[] args) 
	{ 
		int userInput = Int32.Parse(Console.ReadLine().Trim());
		int tempValue = 0;
		
		if(userInput != null && userInput > 0)
		{
			for(int i = 0; i < userInput; i++)
			{
				tempValue += i;
			}
			Console.WriteLine("{0}", tempValue);
		}
		else 
		{ Console.WriteLine("{0}", userInput); }
		Console.ReadKey();
	}
}
