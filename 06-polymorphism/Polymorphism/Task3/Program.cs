using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithmeticProgression = new ArithmeticProgression(1, 5);
  
            PrintSeries(arithmeticProgression,5);
            PrintIndexable(arithmeticProgression, 5);

            Console.WriteLine();

            List list = new List(15);

            PrintSeries(list, 5);
            PrintIndexable(list, 5);

        }

        /// <summary>
        /// Prints elements 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
        static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series.GetCurrent()); 
                series.MoveNext();
            }
        }

        /// <summary>
        /// Prints elements 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
        static void PrintIndexable(IIndexable indexable, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(indexable[i]);
            }
        }
    }
}
