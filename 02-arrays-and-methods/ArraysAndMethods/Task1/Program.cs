using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray();

            SortAndGetMinAndMaxValues(array,out int min, out int max);

            PrintArray(array);
          
        }

        /// <summary>
        /// Returns an array with a random filled.
        /// </summary>
        /// <returns>An array consisting of 50 integer random values</returns>
        static int[] GenerateArray()
        {
            int[] newArray = new int[50];

            Random random = new Random();

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(500);
            }
            return newArray;
        }

        /// <summary>
        /// Returns sorted array, out min value of this array and out max value of this array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>An array consisting of sorted values</returns>
        static int[] SortAndGetMinAndMaxValues(int[] array, out int min, out int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);                     
                    }
                }
            }

            min = array[0];
            max = array[^1];

            return array;
        }

        /// <summary>
        /// Writes an array in the console. Each element starts with a new line.
        /// </summary>
        /// <param name="array">Intput array for print in the console</param>
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }





    }
}
