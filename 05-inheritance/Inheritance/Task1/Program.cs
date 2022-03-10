using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Alexnader", "Pshenichnikov", "V", new DateTime(2000, 7, 4), new DateTime(2010, 6, 4), "Developer", 1000, new ContactInformation("79090909444", "Aa@mail.ru"));
            Console.WriteLine(emp);

            User user = new Employee("Alexander", "Pshenichnikov", "V", new DateTime(2000, 7, 4), new DateTime(2010, 6, 4), "Developer", 1000);
            
        }
    }
}
