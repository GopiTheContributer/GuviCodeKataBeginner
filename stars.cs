using System;

public class Test
{
	public static void Main()
	{
		int value = Convert.ToInt32(Console.ReadLine());
		string resultToPrint = null;
		string star = "*";
		
		if(value > 0){
			
			for(int i = 0; i < value; i++){
				
				for(int j = 0; j < value; j++){
					resultToPrint += star;	
				}
				
				Console.WriteLine("{0}",resultToPrint);
				resultToPrint = null;
			}
		}
		else {
			Console.WriteLine("not a valid input");
			Console.ReadLine();
		}
	}
}
