using System;
using System.Text.RegularExpressions;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string valueToCheck = GetValue();

            //string scientificNotationValue = "5.75124214e-54214";
            //string commonNotationValue = "-4.2145";

            Console.WriteLine(CheckValue(valueToCheck));
        }

        /// <summary>
        /// Gets a string from the user using the console 
        /// </summary>
        /// <returns>String from user</returns>
        static string GetValue() => Console.ReadLine() ?? throw new ArgumentNullException("String is null");

        /// <summary>
        /// Check value on the accessory to different notations
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The line with the comment to which it belongs</returns>
        static string CheckValue(string value)
        {
            if (IsScientificNotation(value))
            {
                return "Это число в научной нотации";
            }

            else if (IsCommonNotation(value))
            {
                return "Это число в обычной нотации";
            }

            else
            {
                return "Это не число";
            }
        }

        /// <summary>
        /// Check value on the Scientific Notation accessory
        /// </summary>
        /// <param name="value"></param>
        /// <returns>If value belongs to Scientific Notation - true, otherwise - false</returns>
        static bool IsScientificNotation(string value)
        {
            string pattern = @"^-?\d+\.\d+e-?\d+";

            if (Regex.IsMatch(value, pattern))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check value on the Common Notation accessory
        /// </summary>
        /// <param name="value"></param>
        /// <returns>If value belongs to Common Notation - true, otherwise - false</returns>
        static bool IsCommonNotation(string value)
        {
            string pattern = @"^-?\d+(\.\d+)?$";

            if (Regex.IsMatch(value, pattern))
            {
                return true;
            }

            return false;
        }
    }
}
