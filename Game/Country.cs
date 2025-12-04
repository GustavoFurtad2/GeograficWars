using System.Text.Json.Serialization;

namespace GeograficWars.Game
{
    public class Country
    {
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        [JsonPropertyName("displayname")]
        public string Name { get; private set; }

        [JsonPropertyName("continent")]
        public string Continent { get; private set; }

        [JsonPropertyName("path")]
        public string ImagePath { get; private set; }

        [JsonPropertyName("x")]
        public double X { get; private set; }

        [JsonPropertyName("y")]
        public double Y { get; private set; }

        [JsonPropertyName("scale")]
        public double Scale { get; private set; }

        public Country(string id, string name, string continent, string imagePath, double x, double y, double scale)
        {
            Id = id;
            Name = name;
            Continent = continent;
            ImagePath = imagePath;
            X = x;
            Y = y;
            Scale = scale;
        }
    }
}
