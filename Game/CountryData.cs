using System.Text.Json.Serialization;

namespace GeograficWars.Game
{
    public class CountryData
    {
        [JsonPropertyName("id")]
        public string CountryId { get; private set; }

        [JsonPropertyName("displayname")]
        public string Name { get; private set; }

        [JsonPropertyName("continent")]
        public string Continent { get; private set; }

        [JsonPropertyName("x")]
        public double X { get; private set; }

        [JsonPropertyName("y")]
        public double Y { get; private set; }

        [JsonPropertyName("chunks")]
        public List<ChunkData> ChunksData { get; set; }

        [JsonConstructor]
        public CountryData(string countryId, string name, string continent, double x, double y, List<ChunkData> chunksData)
        {
            CountryId = countryId;
            Name = name;
            Continent = continent;
            X = x;
            Y = y;
            ChunksData = chunksData;
        }
    }
}
