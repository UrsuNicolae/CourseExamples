namespace Exemple.ClassMembers
{
    public class Hotel
    {
        private List<Room> rooms = new List<Room>();

        public static decimal TotalIncome { get; private set; } = 0;

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }

        public Room FindRoomByType(string type)
        {
            foreach (var room in rooms)
            {
                if (room.RoomType == type)
                {
                    return room;
                }
            }

            throw new Exception("Room not foud!");
        }

        public Room FindRoomByNumber(int number)
        {

           foreach (var room in rooms)
            {
                if (room.RoomNumber == number)
                {
                    return room;
                }
            }

            throw new Exception("Room not foud!");
        }

        public void ListAvailableRooms()
        {
            foreach (var room in rooms)
            {
                if (!room.IsOccupied)
                {
                    room.DisplayInfo();
                }
            }
        }
    }
}
