using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = GenerateArray();

            PrintArray(array);

            ReplacePositiveElementsWithZero(array);

            PrintArray(array);
        }

        /// <summary>
        /// Generates three-dimensional array with a random values
        /// </summary>
        /// <returns>The three-dimensional array consisting of 4 by 4 by 12 integer random values</returns>
        static int[,,] GenerateArray()
        {
            int[,,] newArray = new int[4, 4, 12];

            Random random = new Random();

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    for (int k = 0; k < newArray.GetLength(2); k++)
                    {
                        newArray[i, j, k] = random.Next(-30, 30);
                    }
                }
            }

            return newArray;
        }

        /// <summary>
        /// Replaces all positive values in the input array with zero values
        /// </summary>
        /// <param name="array"></param>
        static void ReplacePositiveElementsWithZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0) array[i, j, k] = 0;
                    }
                }
            }

        }

        /// <summary>
        /// Writes an array in the console. Each 1-dimensional is separated by a space from the other
        /// </summary>
        /// <param name="array">Intput array for print in the console</param>
        static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k],5} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
