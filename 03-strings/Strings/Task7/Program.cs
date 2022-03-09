using System;
using System.Text.RegularExpressions;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");

            //string text = GetText();
            string text = "В 7:55 я встал, позавтракал и к 10:77 пошел на работу. 24:000";

            int result = NumberOfTimes(text);

            Console.WriteLine($"Время в тексте присутствует {result} раз(а)");
        }

        /// <summary>
        /// Gets a string from the user using the console 
        /// </summary>
        /// <returns>String from user</returns>
        static string GetText() => Console.ReadLine() ?? throw new ArgumentNullException("String is null");

        /// <summary>
        /// Counting the number of times occurring in the text
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Number of times</returns>
        static int NumberOfTimes(string text)
        {
            string pattern = @"\b(\d|1\d|2[0-3]):[0-5]\d\b";

            return Regex.Matches(text, pattern).Count;
        }
    }
}
