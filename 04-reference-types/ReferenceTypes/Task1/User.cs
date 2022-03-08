using System;

namespace Task1
{
    internal class User
    {
        private string name;
        private string lastName;
        private string patronymic;
        private int age;
        private DateTime birthDay;

        /// <summary>
        /// User name
        /// </summary>
        public string Name
        {
            get => name;
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect name");
                }
                name = value;
            }
        }

        /// <summary>
        /// User LastName
        /// </summary>
        public string Lastname
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect lastname");
                }
                lastName = value;
            }
        }
        /// <summary>
        /// User Patronymic
        /// </summary>
        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect patronymic");
                }
                patronymic = value;
            }
        }

        /// <summary>
        /// User Age
        /// </summary>
        public int Age
        {
            get => age;
            set
            {
                if (value < 1 || value > 150)
                {
                    throw new ArgumentException("Incorrect age");
                }
                age = value;
            }
        }

        /// <summary>
        /// User birthday
        /// </summary>
        public DateTime BirthDay
        {
            get => birthDay;

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Incorrect BirthDay");
                }

                birthDay = value;
            }
        }


        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="patronymic"></param>
        /// <param name="birthday"></param>
        public User(DateTime birthday, string lastname, string name, string patronymic)
        {
            Name = name;
            Lastname = lastname;
            Patronymic = patronymic;
            BirthDay = birthday;
            Age = (DateTime.Now - birthday).Days / 365;
        }

        public override string ToString()
        {
            return $"Имя: {Name} Фамилия: {Lastname} Отчество: {Patronymic} Дата рождения: {birthDay.ToShortDateString()} Возраст: {age}";
        }
    }
}
