using System;

public class Test
{
	public static void Main()
	{
		// check palindrome using pre-defined functions.
		
		string inputNumber = Console.ReadLine().Trim();
		
		if(!String.IsNullOrEmpty(inputNumber)){
			string temp = null;
			
			char[] inputNumToChar =  inputNumber.ToCharArray();
			Array.Reverse(inputNumToChar);
			
			temp = new string(inputNumToChar);
			
			if(temp == inputNumber)
				Console.WriteLine("The given number is the Palindrome");
			else
				Console.WriteLine("Not a Palindrome number");
			
			Console.ReadKey();
			return;	
		}
		Console.WriteLine("Not a valid input");
		Console.ReadKey();
		return;
	}
}