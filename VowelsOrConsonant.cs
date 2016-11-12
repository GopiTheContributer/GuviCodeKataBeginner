using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string _input = Console.ReadLine().Trim().ToLower();

            if (_input != "")
            {
                char userInput = Convert.ToChar(_input);
                switch (userInput)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Entered character is a vowels");
                        break;
                    default:
                        Console.WriteLine("entered charater is a consonant");
                        break;
                }
            }
            else
                Console.WriteLine("must have value");
            Console.ReadKey();
        }
    }
}
