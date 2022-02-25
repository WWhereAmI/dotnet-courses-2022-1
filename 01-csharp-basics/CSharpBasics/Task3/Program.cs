using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа строит пирамидку по заданному числу N");

            int N;

            while (true)
            {
                Console.Write("Введите число N: ");

                if (int.TryParse(Console.ReadLine(), out N) && N > 0) break;
                else Console.WriteLine("Введено неккоректное значение высоты пирамидки. Повторите попытку...");
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (i * 2) + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }
    }
}
