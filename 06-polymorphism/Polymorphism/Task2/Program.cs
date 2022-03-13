using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricProgression geometricProgression = new GeometricProgression(1, 2);

            PrintSeries(geometricProgression, 10);

        }

        /// <summary>
        /// Prints elements 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
        static void PrintSeries(ISeries value, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(value.GetCurrent());
                value.MoveNext();                
            }
        }
    }
}
