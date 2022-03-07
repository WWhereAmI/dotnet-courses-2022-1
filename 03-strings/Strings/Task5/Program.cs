using System;
using System.Text.RegularExpressions;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");

            //string input = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";

            string input = GetString();
            string pattern = @"<.+?>";
            string replacement = "_";

            Console.WriteLine(ReplaceByPattern(input, pattern, replacement));

        }

        /// <summary>
        /// Gets a string from the user using the console 
        /// </summary>
        /// <returns>String from user</returns>
        static string GetString() => Console.ReadLine() ?? throw new ArgumentNullException("String is null");

        /// <summary>
        /// replace the entered text with a template, with a replacement string 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns>Modify string</returns>
        static string ReplaceByPattern(string input, string pattern, string replacement)
        {
            return Regex.Replace(input, pattern, replacement);
        }
    }
}
