using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user2 = new User("Alexander", "Pshenichnikov", "V", new DateTime(2000, 7, 4));
            Console.WriteLine(user2);
        }
    }
}
