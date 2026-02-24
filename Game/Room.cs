using System.Reflection.Metadata.Ecma335;

namespace GeograficWars.Game
{
    public class Room
    {
        public string RoomId { get; private set; } = string.Empty;

        public string RoomName { get; private set; } = string.Empty;

        private GameState _state;
        private PlayersManager _playersManager;
        private CountriesManager _countriesManager;

        public Room(string roomId, string roomName)
        {
            RoomId = roomId;
            RoomName = roomName;

            _state = new GameState();
            _playersManager = new PlayersManager(_state);
            _countriesManager = new CountriesManager(_state);
        }

        public void RoomStart()
        {
            _state.newGame();
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
            return _state.Players.Values.Select(p => p.Name).ToList();
        }

    }
}
