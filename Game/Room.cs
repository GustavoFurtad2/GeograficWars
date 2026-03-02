using System.Reflection.Metadata.Ecma335;

namespace GeograficWars.Game
{
    public class Room
    {
        public string RoomId { get; private set; } = string.Empty;

        public string RoomName { get; private set; } = string.Empty;

        private GameState _gameState;
        private PlayersManager _playersManager;
        private CountriesManager _countriesManager;

        public Room(string roomId, string roomName)
        {
            RoomId = roomId;
            RoomName = roomName;

            _gameState = new GameState();
            _playersManager = new PlayersManager(_gameState);
            _countriesManager = new CountriesManager(_gameState);
        }

        public void RoomStartGame()
        {
            _gameState.initGame();
        }

        public bool AddPlayer(string playerName)
        {
            _playersManager.CreatePlayer(playerName);

            return true;
        }

        public CountriesManager GetCountriesManager()
        {
            return _countriesManager;
        }

        public List<string> GetPlayersName()
        {
            return _gameState.Players.Values.Select(p => p.Name).ToList();
        }

    }
}
