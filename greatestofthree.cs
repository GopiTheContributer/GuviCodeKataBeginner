using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            int firstInt = Convert.ToInt32(Console.ReadLine().Trim());
            int secondInt = Convert.ToInt32(Console.ReadLine().Trim());
            int thirdInt = Convert.ToInt32(Console.ReadLine().Trim());

            if (firstInt > secondInt && firstInt > thirdInt)
                Console.WriteLine("first value is the largest than other.");
            else if (secondInt > firstInt && secondInt > thirdInt)
                Console.WriteLine("second value is largest than other.");
            else
                Console.WriteLine("third value is largest than other.");

            Console.ReadKey();
        }
    }
}
