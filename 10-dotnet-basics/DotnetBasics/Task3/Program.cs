using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash first = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash second = new TwoDPointWithHash(10, 10);

            TwoDPointWithHash third = new TwoDPointWithHash(1, 10);
            TwoDPointWithHash fourth = new TwoDPointWithHash(10, 1);

            Console.WriteLine($"Хеш точки с коорд (1,1): {first.GetHashCode()}");
            Console.WriteLine($"Хеш точки с коорд (10,10): {second.GetHashCode()}");
            Console.WriteLine($"Хеш точки с коорд (1,10): {third.GetHashCode()}");
            Console.WriteLine($"Хеш точки с коорд (10,1): {fourth.GetHashCode()}");
        }
    }
}
