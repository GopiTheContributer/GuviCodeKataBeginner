using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput) && !string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("total counts in the entered number: {0}", userInput.Length);
                return;
            }
            else
            {
                Console.WriteLine("Must have a value.");
                Console.ReadLine();
                return;
            }
        }
    }
}
