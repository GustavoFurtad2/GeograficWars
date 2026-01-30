namespace GeograficWars.Game
{
    public class Player
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; private set; } = string.Empty;
        public bool Alive { get; private set; } = false;
        public int ConqueredTerritories { get; private set; } = 0;

        public Player(string name)
        {
            Name = name;
        }

    }
}
