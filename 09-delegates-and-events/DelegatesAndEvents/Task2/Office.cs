using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Office
    {
        public event EventHandler<OfficeEventArgs> PersonCame;
        public event EventHandler<OfficeEventArgs> PersonLeft;

        private List<Person> employeeList = new List<Person>();

        public void Come(Person person)
        {
            Console.WriteLine($"[На работу пришел {person.Name}]");

            employeeList.Add(person);

            PersonCame?.Invoke(this, new OfficeEventArgs(DateTime.Now, person.Name));

            PersonCame += person.OnPersonCame;
            PersonLeft += person.OnPersonLeft;
        }

        public void Leave(Person person)
        {
            if (employeeList.Remove(person))
            {
                Console.WriteLine($"[{person.Name} ушёл домой]");

                PersonCame -= person.OnPersonCame;
                PersonLeft -= person.OnPersonLeft;

                PersonLeft?.Invoke(this, new OfficeEventArgs(DateTime.Now, person.Name));

                
            }       
        }

    }
}
