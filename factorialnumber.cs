using System;
using System.Text.RegularExpressions;

public class Test
{
	public static void Main()
	{
		string regex = "[0-9]";
		
		string userInput = Console.ReadLine().Trim();
		
		if(!string.IsNullOrEmpty(userInput)){
			
			if(Regex.IsMatch(userInput, regex)){
				
				int fact = Convert.ToInt32(userInput);
				
				if(fact > 1) { Console.WriteLine("{0}",Recursive(fact)); }
				else if(fact ==1) {Console.WriteLine("1");}
				else { Console.WriteLine("not a valid input");Console.ReadKey(); }
				
			}
			else 
			{
				Console.WriteLine("not a valid input");Console.ReadKey();
			}
		}
		else {
				Console.WriteLine("not a valid input");Console.ReadKey();
		}
	}
	
	private static int Recursive(int input){
		int temp = 1;
		
		for(int i  = 1 ; i <= input; i++){
			temp  = i * Recursive(input - 1); 
		}
		return temp;
	}
	
}
