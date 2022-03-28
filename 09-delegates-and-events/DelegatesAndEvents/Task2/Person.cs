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
            string message;

            if (sender is Office)
            {
                if (e.DateTime.Hour > 6 && e.DateTime.Hour < 12)
                {
                    message = "Доброе утро";
                }
                 else if (e.DateTime.Hour > 12 && e.DateTime.Hour < 17)
                {
                    message = "Добрый день";
                }
                else
                {
                    message = "Добрый вечер";
                }
                Console.WriteLine($"{message}, {e.Name}! - сказал {Name}");
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
