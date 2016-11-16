using System;

namespace Guvi_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base number: ");
            string baseNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter the power value. ");
            string powerNumber = Console.ReadLine().Trim();

            if (!string.IsNullOrWhiteSpace(baseNumber) && !string.IsNullOrEmpty(powerNumber))
            {
                #region "by using predefined math function"
                //Console.WriteLine("power of the given integer is: {0}", Math.Pow(Convert.ToDouble(userInput1), Convert.ToDouble(userInput2)));
                //Console.ReadKey();
                //return;
                #endregion

                #region "using own logic"
                int _baseValue = Convert.ToInt32(baseNumber);
                int _powerValue = Convert.ToInt32(powerNumber);
                double _result = 1;
                for (int i = 0; i < _powerValue; i++)
                {
                    _result *= _baseValue;
                }

                Console.WriteLine("{0}", _result);
                Console.ReadKey();
                return;
                #endregion
            }
            else
            {
                Console.WriteLine("Must have a value: ");
                Console.ReadKey();
                return;
            }
        }
    }
}
