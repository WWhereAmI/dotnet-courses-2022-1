using System;
using System.Globalization;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo[] cultures =
            {
                CultureInfo.InvariantCulture,
                new CultureInfo("en-US"),
                new CultureInfo("ru-RU")
            };

            PrintCultureDifference(cultures);

        }

        /// <summary>
        ///  Printing the difference between the input array of culture
        /// </summary>
        /// <param name="cultures"></param>
        static void PrintCultureDifference(CultureInfo[] cultures)
        {
            DateTime dateTime = DateTime.Now;
            double value = 1_000_000.14881337;

            foreach (CultureInfo culture in cultures)
            {
                Console.WriteLine(
                    $"Culture:{(culture.Name == string.Empty ? "Invariant" : culture.Name),10}" +
                    $" Date: {dateTime.ToString(culture),20}" +
                    $" Value: {value.ToString("N", culture),10}");
            }
        }
    }
}
