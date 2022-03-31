using System;

namespace MathLibrary
{
    static public class MathFunctions
    {
        static public long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Negative number");
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        static public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

    }
}
