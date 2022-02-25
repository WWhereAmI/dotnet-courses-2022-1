using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа строит N пирамидок с инкрементирующимся значением высоты");

            int N;

            while (true)
            {
                Console.Write("Введите число N: ");

                if (int.TryParse(Console.ReadLine(), out N) && N > 0) break;
                else Console.WriteLine("Введено неккоректное значение колличества пирамидок. Повторите попытку...");
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    for (int k = N - 1; k > j; k--)
                    {
                        Console.Write(" ");
                    }

                    for (int l = 0; l < (j * 2 + 1); l++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();

                }
            }


        }
    }
}
