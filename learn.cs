
using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine().Trim());

            if (userInput != 0)
            {
                if (userInput > 0)
                    Console.WriteLine("the given number is positive.");
                else
                    Console.WriteLine("the given number is negative.");
            }
            else
                Console.WriteLine("the given number is zero");
            Console.ReadKey();
        }
    }
}
