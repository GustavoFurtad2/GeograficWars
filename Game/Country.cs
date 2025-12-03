namespace GeograficWars.Game
{
    public class Country
    {
        public string Name { get; private set; }
        public string Continent { get; private set; }
        public string ImagePath { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Scale { get; private set; }

        public Country(string name, string continent, string imagePath, double x, double y, double scale)
        {
            Name = name;
            Continent = continent;
            ImagePath = imagePath;
            X = x;
            Y = y;
            Scale = scale;
        }
    }
}
