using System;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string inputText = GetString();

            Console.Write("Введите вторую строку: ");
            string symbolsToDouble = GetString();

            Console.WriteLine(CharacterDoubling(inputText, symbolsToDouble));

        }

        /// <summary>
        /// Gets a string from the user using the console 
        /// </summary>
        /// <returns>String from user</returns>
        static string GetString() => Console.ReadLine().ToLower() ?? throw new ArgumentNullException("String is null");

        /// <summary>
        /// Doubling of string characters consisting of the second line
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sybmolsToDouble"></param>
        /// <returns>A string with duplicated characters</returns>
        static string CharacterDoubling(string inputText, string symbolsToDouble)
        {
            StringBuilder result = new StringBuilder();

            foreach (var chr in inputText)
            {
                if (symbolsToDouble.Contains(chr))
                {
                    result.Append(chr, 2);
                }
                else
                {
                    result.Append(chr);
                }
            }

            return result.ToString();
        }
    }
}
