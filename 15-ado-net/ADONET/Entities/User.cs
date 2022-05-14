using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        public int ID { get; set; }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FirstName is Null");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The max FirstName length is 50");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("LastName is Null");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The max LastName length is 50");
                }
                lastName = value;
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value > DateTime.Now || value.Year <= DateTime.Now.Year - 150)
                {
                    throw new ArgumentOutOfRangeException("Incorrect date value");
                }

                birthDate = value;
            }
        }
        public int Age
        {
            get => new DateTime(DateTime.Now.Subtract(BirthDate).Ticks).Year;
        }

        public List<Award> UserAwards { get; set; } = new List<Award>();

        public string UserAwardsList
        {
            get
            {
                return string.Join(Environment.NewLine, UserAwards);
                //StringBuilder result = new StringBuilder();
                //foreach (var item in UserAwards)
                //{
                //    result.Append("-" + item + "\n");
                //}
                //return result.ToString();
            }
        }

        public User()
        {

        }

        public User(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
