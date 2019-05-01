using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopValue = 1;
            do
            {
                Console.WriteLine("Hello");
                loopValue++;
            } while (loopValue <= 5);

            Console.ReadKey();
        }
    }
}
