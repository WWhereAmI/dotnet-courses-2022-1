using System;
using Task1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new Employee("Alexander", "Pshenichnikov",
                "Vyacheslavovich", new DateTime(2000, 07, 04), new DateTime(2020, 07, 04),
                "Developer", 2000);

            User user2 = new Employee("Semen", "Pertov",
                "Maksimovich", new DateTime(2003, 04, 12), new DateTime(2017, 04, 05),
                "Developer", 1500);

            User user3 = new Employee("Alice", "Ivanova",
                "Aleksandrovna", new DateTime(2002, 06, 13), new DateTime(2018, 05, 05),
                "Web-Developer", 2000);

            Console.WriteLine(user.Equals(user2));
            Console.WriteLine(user.Equals(user3));


        }
    }
}
