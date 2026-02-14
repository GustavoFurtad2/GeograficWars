using System.Text.Json.Serialization;

namespace GeograficWars.Game
{
    public class ChunkData
    {
        [JsonPropertyName("x")]
        public double X { get; private set; }

        [JsonPropertyName("y")]
        public double Y { get; private set; }

        [JsonPropertyName("w")]
        public double W { get; private set; }

        [JsonPropertyName("h")]
        public double H { get; private set; }

        public ChunkData(double x, double y, double w, double h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
        }
    }
}
