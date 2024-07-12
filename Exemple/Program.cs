using Exemple.ClassMembers;
using System.Runtime.CompilerServices;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();

            while (true)
            {
                Console.WriteLine("Hotel Management System");
                Console.WriteLine("1. Add room");
                Console.WriteLine("2. Remove room");
                Console.WriteLine("3. List available rooms");
                Console.WriteLine("4. Find room by type");
                Console.WriteLine("5. Check in");
                Console.WriteLine("6. Check out");
                Console.WriteLine("7. Exit");

                var option = char.Parse(Console.ReadLine());
                switch(option)
                {
                    case '1': AddRoom(); break;
                    case '2': RemoveRom(); break;
                    case '3': hotel.ListAvailableRooms(); break;
                    case '4': FindRoomByType(); break;
                    case '5': CheckIn(); break;
                    case '6': CheckOut(); break;
                    case '7':  return;
                }
            }

            void AddRoom()
            {

               Console.WriteLine("Enter room number: ");
                var roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter room type: ");
                var roomType = Console.ReadLine();
                Console.WriteLine("Enter room price: ");
                var roomPrice = decimal.Parse(Console.ReadLine());

                hotel.AddRoom(new Room(roomNumber, roomType, roomPrice));
            };

            void RemoveRom()
            {
                Console.WriteLine("Enter room number: ");
                var roomNumber = int.Parse(Console.ReadLine());
                try
                {
                    var room = hotel.FindRoomByNumber(roomNumber);
                    hotel.RemoveRoom(room);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            void FindRoomByType()
            {
                Console.WriteLine("Enter room type: ");
                var roomType = Console.ReadLine();
                try
                {
                    var room = hotel.FindRoomByType(roomType);
                    room.DisplayInfo();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            void CheckIn()
            {
                Console.WriteLine("Enter room number to checkin ");
                var roomNumber = int.Parse(Console.ReadLine());
                try
                {
                    var room = hotel.FindRoomByNumber(roomNumber);
                    room.CheckIn();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            void CheckOut()
            {
                Console.WriteLine("Enter room number to checkout ");
                var roomNumber = int.Parse(Console.ReadLine());
                try
                {
                    var room = hotel.FindRoomByNumber(roomNumber);
                    room.CheckOut();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            /*hotel.AddRoom(new Room(1, "Single", 100));
            hotel.AddRoom(new Room(2, "Double", 200));
            hotel.AddRoom(new Room(3, "Single", 100));
            hotel.AddRoom(new Room(4, "KingSize", 300));*/

        }
    }
}
