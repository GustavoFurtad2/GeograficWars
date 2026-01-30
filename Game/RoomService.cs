namespace GeograficWars.Game
{
    public class RoomService
    {
        private readonly Dictionary<string, Room> _rooms = new();

        public Room CreateRoom(string roomId, string roomName)
        {
            _rooms[roomId] = new Room(roomId, roomName);

            return _rooms[roomId];
        }

        public Room GetRoom(string roomId)
            => _rooms.TryGetValue(roomId, out var room) ? room : null;

        public void RemoveRoom(string roomId)
            => _rooms.Remove(roomId);
    }
}
