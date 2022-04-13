using System;
using System.Text.Json.Serialization;

namespace Task1
{
    internal class User
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("age")]
        public int Age
        {
            get => DateTime.Now.Subtract(BirthDate).Days / 365;
        }

        public User() { }
        
        public User(int ID, string firstName, string lastName, DateTime birthDate)
        {
            this.ID = ID;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
