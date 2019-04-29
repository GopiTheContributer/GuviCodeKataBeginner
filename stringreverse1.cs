using System;
public class Test
{
	public static void Main()
	{
		string userInput = Console.ReadLine().Trim();
		string output = string.Empty;
		if(!string.IsNullOrEmpty(userInput)){
			char[] temp = userInput.ToCharArray();
			Array.Reverse(temp);
			foreach(char item in temp){
				output += item;
			}Console.WriteLine("{0}",output);
		}
		else
		{
			Console.WriteLine("Not a valid input");
		}
	}
}
