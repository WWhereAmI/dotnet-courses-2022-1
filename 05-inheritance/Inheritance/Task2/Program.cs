using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ring ring = new Ring(5, 5, 15, 10);
            Console.WriteLine(ring);

            ring.InnerRadius = 25;
        }   
    }
}
