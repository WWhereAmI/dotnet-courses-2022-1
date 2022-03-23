using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int> { 1, 2, 3 };

            DynamicArray<int> dynArray = new DynamicArray<int>();
            dynArray.Add(1);
            dynArray.Add(2);

            foreach (var item in dynArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
