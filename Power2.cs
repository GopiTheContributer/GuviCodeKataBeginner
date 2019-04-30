using System;

namespace guvibegin
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
