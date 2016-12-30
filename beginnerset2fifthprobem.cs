using System;

public class Test
{
    public static void Main()
    {
        int firstInput = int.Parse(Console.ReadLine().Trim());
        int secondInput = int.Parse(Console.ReadLine().Trim());

        if (firstInput != null && secondInput != null && firstInput != 0 && secondInput != 0
            && firstInput > 0 && secondInput > 0)
        {
            string result = null;
            if (firstInput > secondInput)
            {
                Console.WriteLine("First input should be greater than the second input.");
                Console.ReadKey();
                return;
            }

            for (int i = 1; i <= secondInput; i++)
            {
                if (i % 2 == 0)
                {
                    if (result == null)
                        result = i.ToString();
                    else
                        result += ", " + i.ToString();
                }
            }
            Console.WriteLine("{0}", result);
            Console.ReadKey();
            return;
        }
        Console.WriteLine("not a valid input");
        Console.ReadKey();
    }
}
