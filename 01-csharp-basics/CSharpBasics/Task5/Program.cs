using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int border = 1000;

            for (int i = 1; i < border; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Сумма всех чисел меньше {border}, кратных 3, или 5 равна: {sum}");
        }
    }
}
