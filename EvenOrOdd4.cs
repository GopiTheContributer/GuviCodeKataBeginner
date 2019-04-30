using System;

namespace Guvibegin
{
    class Program
    {
        static void Main(string[] ar)
        {
            Console.WriteLine("Enter no: ");
            int userInput = Convert.ToInt32(Console.ReadLine().Trim());

            if (userInput > 0)
            {
                if ((userInput % 2) == 0)
                {
                    Console.WriteLine("the given number is even");
                }
                else
                {
                    Console.WriteLine("The given number is odd.");
                }
            }
            else
                Console.WriteLine("number should be in positive");

            Console.ReadKey();
        }
    }
}
