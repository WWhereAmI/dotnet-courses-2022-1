using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DynamicArray<int> list = new DynamicArray<int>(2,0,0,2);

            list.Add(1);

            list.Insert(0,0);
           

            Console.WriteLine(list.Remove(0)); 

            Console.WriteLine(list.Remove(66)); 
           



        }
    }
}
