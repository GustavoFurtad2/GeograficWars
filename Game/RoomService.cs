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

        public string JoinRoom(string roomId, string playerName)
        {
            Room room = GetRoom(roomId);
            
            if (room == null)
            {
                return null;
            }
            
            return room.AddPlayer(playerName);
        }


    }
}
