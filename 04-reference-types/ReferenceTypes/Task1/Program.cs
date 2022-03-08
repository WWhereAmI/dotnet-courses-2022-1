using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user2 = new User(new DateTime(2000, 7, 4), "Pshenichnikov", "Alexander", "V");
            Console.WriteLine(user2);
        }
    }
}
