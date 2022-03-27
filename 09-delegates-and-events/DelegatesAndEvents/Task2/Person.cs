using System;

namespace Task2
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;               
        }

        public void OnPersonCame(object sender, OfficeEventArgs e)
        {
            if (sender is Office)
            {
                Console.WriteLine($"{e.Message}, {e.Name}! - сказал {Name}");
            }               
        }

        public void OnPersonLeft(object sender, OfficeEventArgs e)
        {
            if (sender is Office)
            {
                Console.WriteLine($"До свидания, {e.Name}! - сказал {Name}");
            }
        }
    }
}
