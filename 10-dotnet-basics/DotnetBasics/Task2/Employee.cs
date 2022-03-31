using System;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    internal class Employee : User, IEquatable<Employee>
    {
        private DateTime admissionToWork;
        private string title;
        private int salary;


        public int Experience { get => (DateTime.Now - admissionToWork).Days / 365; }

        /// <summary>
        /// Employee phone, email, telegram
        /// </summary>
        public ContactInformation ContactInformation { get; set; }

        public string Title
        {
            get => title;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect title");
                }
                title = value;
            }
        }

        public int Salary
        {
            get => salary;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect salary");
                }
                salary = value;
            }
        }

        public Employee(string name, string lastname, string patronymic, DateTime birthDay, DateTime admissionToWork, string title, int salary, ContactInformation contacts = null)
            : base(name, lastname, patronymic, birthDay)
        {
            Salary = salary;
            this.admissionToWork = admissionToWork;
            ContactInformation = contacts;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Name} {Lastname} {Patronymic} {Age}г. Должность: {title} ЗП: {salary} Опыт работы: {Experience}. Контакты: {ContactInformation}";
        }

        public bool Equals([AllowNull] Employee other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(other, null)) return false;
            if (GetHashCode() == other.GetHashCode()) return true;

            return Salary == other.Salary;

        }
        public override bool Equals(object obj)
        {          
            if (ReferenceEquals(this, obj)) return true;
            if (ReferenceEquals(obj, null)) return false;
            if (GetHashCode() != obj.GetHashCode()) return false;

            if (obj is Employee employee)
            {
                return Salary == employee.Salary;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Salary, Title);
        }
    }
}
