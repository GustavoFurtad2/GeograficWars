using GeograficWars.Shared;

namespace GeograficWars.Game
{
    public class GameState
    {
        public Dictionary<string, Player> Players { get; } = new();
        public Dictionary<string, Country> Countries { get; } = new();

        public List<string> PlayersOrderID { get; private set; } = new();

        public string? CurrentPlayerTurnId { get; set; }

        public void initGame()
        {
            PlayersOrderID = Players.Keys.ToList();

            Shuffler.Shuffle(PlayersOrderID);
        }
    }
}
