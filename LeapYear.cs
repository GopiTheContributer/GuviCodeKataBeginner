using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year: ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrEmpty(userInput))
            {
                if (userInput.Length != 4)
                {
                    Console.WriteLine("year should be in 4 character length.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    int _isLeapYear = Convert.ToInt32(userInput);

                    if (_isLeapYear % 4 == 0 || _isLeapYear % 400 == 0)
                    {
                        Console.WriteLine("the given year is a leap year");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("the given year is not a leap year");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            else 
            {
                        Console.WriteLine("must have a value.");
                        Console.ReadKey();
                        return;
            }
        }
    }
}
