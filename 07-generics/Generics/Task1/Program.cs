using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DynamicArray<int> list = new DynamicArray<int>(1,2,3,4,5,6,7,8);

            list.Add(1);

            list.Insert(0,0);
            list.Insert(1,8);

            Console.WriteLine(list.Remove(0)); 

            Console.WriteLine(list.Remove(66)); 
           



        }
    }
}
