using System;
using System.Text.Json.Serialization;

namespace Task1
{
    public class Award
    {
        private string title;
        private string description;

        public static int GUID { get; set; } = 0;

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("title")]
        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FirstName is Null");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The max title length is 50");
                }

                title = value;
            }
        }

        [JsonPropertyName("description")]
        public string Description
        {
            get => description;
            set
            {
                if (value.Length > 250)
                {
                    throw new ArgumentOutOfRangeException("The max Description length is 250");
                }

                description = value;
            }
        }

        public Award() 
        {
            ID = GUID++;
        }
        public Award(string title, string description)
        {
            ID = GUID++;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return Title;
        }

        public override bool Equals(object obj)
        {
            return Title.Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Title);
        }
    }
}
