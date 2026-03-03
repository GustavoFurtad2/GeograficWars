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

        public RoomState State { get; set; } = RoomState.Lobby;

        public string AdminID { get; private set; }

        public Room(string roomId, string roomName)
        {
            RoomId = roomId;
            RoomName = roomName;

            _gameState = new GameState();
            _playersManager = new PlayersManager(_gameState);
            _countriesManager = new CountriesManager(_gameState);
        }

        public void StartGame(string playerId)
        {
            if (playerId == AdminID)
            {
                State = RoomState.InGame;

                _gameState.initGame();
            }
        }

        public string AddPlayer(string playerName)
        {
            Player player = _playersManager.CreatePlayer(playerName);

            if (_gameState.Players.Count == 1)
            {
                AdminID = player.Id;
            }

            return player.Id;
        }

        public CountriesManager GetCountriesManager()
        {
            return _countriesManager;
        }

        public List<string> GetPlayersName()
        {
            return _gameState.Players.Values.Select(p => p.Name).ToList();
        }

        public int GetNumbersOfPlayer()
        {
            return _gameState.Players.Count;
        }

    }
}
