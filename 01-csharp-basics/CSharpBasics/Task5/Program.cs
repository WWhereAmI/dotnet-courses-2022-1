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

            Console.WriteLine(sum);
        }
    }
}
