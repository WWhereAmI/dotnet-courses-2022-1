using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray();

            PrintArray(array);

            Console.WriteLine(GetSumOfNonNegativeElements(array));
        }

        /// <summary>
        /// Returns an array with a random filled.
        /// </summary>
        /// <returns>An array consisting of 25 integer random values</returns>
        static int[] GenerateArray()
        {
            int[] newArray = new int[25];

            Random random = new Random();

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(-5, 5);
            }
            return newArray;
        }

        /// <summary>
        /// Calculate the sum of positive elements in the input array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>The integer sum of positive elements</returns>
        static int GetSumOfNonNegativeElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// Writes an array in the console. Each element starts with a new line.
        /// </summary>
        /// <param name="array">Intput array for print in the console</param>
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item,2} ");
            }
            Console.WriteLine();
        }
    }
}
