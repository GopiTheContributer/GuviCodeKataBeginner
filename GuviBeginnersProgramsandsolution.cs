using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = Convert.ToInt32(Console.ReadLine().Trim());
            int secondValue = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("{0}", firstValue + secondValue);
            Console.ReadKey();

        }
    }
}
