using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Task1
{
    public class User
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public static int GUID { get; set; } = 0;

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("first_name")]
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

        [JsonPropertyName("last_name")]
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

        [JsonPropertyName("birth_date")]
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

        [JsonPropertyName("age")]
        public int Age
        {
            get => DateTime.Now.Subtract(BirthDate).Days / 365;
        }

        [JsonPropertyName("user_awards")]
        public List<Award> UserAwards { get; set; } = new List<Award>();

        [JsonIgnore]
        public string UserAwardsList
        {
            get
            {
                StringBuilder result = new StringBuilder();
                foreach (var item in UserAwards)
                {
                    result.Append("-" + item + "\n");
                }
                return result.ToString();
            }
        }


        public User() 
        {
            ID = GUID++;
        }

        public User(string firstName, string lastName, DateTime birthDate)
        {
            ID = GUID++;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
