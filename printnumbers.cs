using System;

class Ideone
{
	public static void Main (string[] args) 
	{
		int numberAddition = 0;
		int oddNumberAddition = 0;
		
		for(int i = 1; i <= 15; i++)
			numberAddition += i;
			
		Console.WriteLine("Addition of number between 1 to 15: {0}",numberAddition);
		
		for(int j = 15; j <= 45; j++)
		{
			if(j%2==1)
				oddNumberAddition += j;
		}
		
		Console.WriteLine("Odd number addition: {0}", oddNumberAddition);
		Console.ReadKey();
	}
}
