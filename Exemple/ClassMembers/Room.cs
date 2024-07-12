namespace Exemple.ClassMembers
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public string RoomType { get; private set; }
        public bool IsOccupied { get; private set; }

        public decimal Price { get; private set; }

        public Room(int roomNumber, string roomType, decimal price)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Price = price;
        }

        public void CheckIn()
        {
            if (IsOccupied)
            {
                Console.WriteLine("Room is already occupied");
            }else
            {
                IsOccupied = true;
            }
            

        }

        public void CheckOut()
        {
            if (IsOccupied)
            {

                IsOccupied = false;
            }else
            {
                Console.WriteLine("Room is already empty");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Room number: {RoomNumber}, Room type: {RoomType}, Price: {Price}, Is occupied: {IsOccupied}");
        }
    }
}
