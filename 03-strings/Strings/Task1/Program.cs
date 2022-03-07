using System;

namespace Task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            double averageLength = AverageLength(GetString());
            
            Console.WriteLine(averageLength);
        }

        /// <summary>
        /// Gets a string from the user using the console 
        /// </summary>
        /// <returns>String from user</returns>
        static string GetString() => Console.ReadLine() ?? throw new ArgumentNullException("String is null");

        /// <summary>
        /// Calculates the average length of the input string. Ignore all Non letters symbols
        /// </summary>
        /// <param name="str"></param>
        /// <returns>The avarege length sting</returns>
        static double AverageLength(string str)
        {
            double lenght = 0;

            foreach (var chr in str)
            {
                if (!char.IsPunctuation(chr) && !char.IsSeparator(chr)) lenght++;
            }

            return lenght / 2;

        }
    }
}
