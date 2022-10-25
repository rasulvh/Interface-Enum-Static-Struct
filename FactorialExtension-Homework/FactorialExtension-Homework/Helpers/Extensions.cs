using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialExtension_Homework.Helpers
{
    public static class Extensions
    {
        public static void CalculateFactorial(this int number)
        {
            int result = 1;

            if (number == 0)
            {
                Console.WriteLine(result);
            }
            else if (number < 0)
            {
                Console.WriteLine("Write correct number");
            }
            else
            {
                for (int i = number; i > 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine(result);
            }
        }
    }
}