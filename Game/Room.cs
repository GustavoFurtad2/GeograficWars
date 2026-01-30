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

        public CountriesManager GetCountriesManager()
        {
            return _countriesManager;
        }

    }
}
