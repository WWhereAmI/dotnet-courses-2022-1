using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };

            DynamicArray<int> dynArray = new DynamicArray<int>(list);

            foreach (var item in dynArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
