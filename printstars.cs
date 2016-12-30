using System;

public class Test
{
	public static void Main()
	{
		int userInput = Convert.ToInt32(Console.ReadLine());
		
		if(userInput > 0) {
			
			string temp= "*";
			string result=null;
			for(int i = 0; i < userInput; i++){
				result += temp;
				
				Console.WriteLine("{0} \n", result);
			}
		}
		else {
			Console.WriteLine("not a valid input");
		}
	}
}
