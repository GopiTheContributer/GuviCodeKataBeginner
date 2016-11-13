using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "[0-9]";
            int total = 0;
            Console.WriteLine("enter a number: ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrEmpty(userInput))
            {
                Regex regexPattern = new Regex(pattern);
                Match isMatch = regexPattern.Match(userInput);
                
                if (isMatch.Success)
                {
                    int convertedValue = Convert.ToInt32(userInput);
                    for (int i = 1; i <= convertedValue; i++)
                    {
                        total += i;
                    }
                    Console.WriteLine("sum of natural number is: {0}", total);
                }
                else
                {
                    Console.WriteLine("input not in a proper format.");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("must have a value");
                Console.ReadLine();
                return;
            }

            Console.ReadKey();
        }
    }
}
