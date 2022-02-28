using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа строит треугольник по заданному числу N");

            int N;

            while (true)
            {
                Console.Write("Введите число N: ");

                if (int.TryParse(Console.ReadLine(), out N) && N > 0) break;
                else Console.WriteLine("Введено неккоректное значение высоты треугольника. Повторите попытку...");
            }

            for (int i = 0; i < N; i++)
            {
                //NewFeathure
                Console.WriteLine(new string('*', i + 1)); 

                //for (int j = 0; j <= i; j++)
                //{
                //    Console.Write("*");
                //}

                //Console.WriteLine();
            }
        }
    }
}
