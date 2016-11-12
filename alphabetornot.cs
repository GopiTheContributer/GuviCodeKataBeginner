using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput != "")
            {
                string _myStrPattern = "[a-zA-Z]";
                Regex _regex = new Regex(_myStrPattern);
                Match m = _regex.Match(userInput);

                if (m.Success)
                    Console.WriteLine("Entered is an alphabet. ");
                else
                    Console.WriteLine("entered value is not an alphabet.");
            }
            else
                Console.WriteLine("Must have a value.");


            Console.ReadKey();
        }
    }
}
