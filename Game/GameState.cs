namespace GeograficWars.Game
{
    public class GameState
    {
        public Dictionary<string, Player> Players { get; } = new();
        public Dictionary<string, Country> Countries { get; } = new();

        public string? CurrentPlayerTurnId { get; set; }
    }
}
