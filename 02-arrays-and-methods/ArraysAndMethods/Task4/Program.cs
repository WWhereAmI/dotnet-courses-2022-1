using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = GenerateArray();

            PrintArray(array);

            Console.WriteLine(GetSumOfElementsOnEvenPositions(array));
        }

        /// <summary>
        /// Generates two-dimensional array with a random values
        /// </summary>
        /// <returns>The two-dimensional array consisting of 6 by 10 integer random values</returns>
        static int[,] GenerateArray()
        {
            int[,] newArray = new int[3, 4];

            Random random = new Random();

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    newArray[i, j] = random.Next(10);
                }
            }
            return newArray;
        }

        /// <summary>
        /// Calculate the sum of elements in the two-dimentional input array, the elemets of which stand on in even sum of index positions
        /// </summary>
        /// <param name="array">The integer sum of elements, which stand on even sum index positions</param>
        static int GetSumOfElementsOnEvenPositions(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Writes an array in the console. Each element starts with a new line.
        /// </summary>
        /// <param name="array">Intput array for print in the console</param>
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],3} ");
                }

                Console.WriteLine();
            }
        }
    }
}
