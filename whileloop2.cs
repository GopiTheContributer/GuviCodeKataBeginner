using System;

namespace g
{
    class Program
    {
        static void Main()
        {
            int loopValue = 1;
            do
            {
                Console.WriteLine("world");
                loopValue++;
            } while (loopValue <= 5);

            Console.ReadKey();
        }
    }
}
