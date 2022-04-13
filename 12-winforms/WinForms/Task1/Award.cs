using System.Text.Json.Serialization;

namespace Task1
{
    internal class Award
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public Award() { }
        public Award(int ID, string title, string description)
        {
            this.ID = ID;
            Title = title;
            Description = description;
        }
    }
}
