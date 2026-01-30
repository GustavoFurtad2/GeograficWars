namespace GeograficWars.Game
{
    public class PlayersManager
    {
        private readonly GameState _state;

        public PlayersManager(GameState state)
        {
            _state = state;
        }

        public Player CreatePlayer(string name)
        {
            Player player = new Player(name);

            _state.Players[player.Id] = player;

            return player;
        }

        public void RemovePlayer(string id)
        {
            if (_state.Players[id] != null)
            {
                _state.Players.Remove(id);
            }
        }
    }
}
