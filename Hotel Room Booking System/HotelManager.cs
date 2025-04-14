using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    internal class HotelManager
    {
       
        private List<Room> chart = new List<Room>();

        public void AddGuest(Room guest)
        {
            chart.Add(guest);
        }
        public void BookRoom(string name, int roomNumber, int numerOfGuest, int stayPerNight)
        {
            foreach (var room in chart)
            {
                if (room.GetRoomNumber() == roomNumber)
                {
                    if (room.GetStatus() == "Available")
                    {
                        room.SetName(name);
                        room.SetNumberOfGuest(numerOfGuest);
                        room.SetCountStayPerNight(stayPerNight);
                        room.SetStatus("Booked");

                        Console.WriteLine($"Room {roomNumber} is Booked for {name}.");
                        return;

                    }
                    else
                    {
                        Console.WriteLine($"Room {roomNumber} is Occupied.");
                    }
                }
            }
             Console.WriteLine("Room is not Found."); 
        }

        public void showAllDetails()
        {
            Console.WriteLine("<=== Hotel Moxy International ===>");
            foreach (var guest in chart)
            {
                Console.WriteLine($"Name: {guest.GetName()}| GuestCount: {guest.GetNumberOfGuest()} | Status : {guest.GetStatus()}"  +
                    $" NumberOfday: {guest.GetCountStayPerNight()}| total: {guest.CalculateBill()} ");
            }
            Console.WriteLine("======================================");
        }

        public void checkout(int roomNumber)
        {
            foreach (var room in chart)
            {
                if (room.GetRoomNumber() == roomNumber)
                {
                    room.SetStatus("Availble");
                    room.SetNumberOfGuest(0);
                    room.SetCountStayPerNight(0);
                    room.SetName("-");
                    Console.WriteLine($"Room {roomNumber} is now Available.");
                    return;
                }
                
            }
            Console.WriteLine("======================================");
        }

        public void checkAvailbilty()
        {
            foreach (var room in chart)
            {
                if(room.GetStatus() == "Availble")
                {
                    Console.WriteLine($"Room Number : {room.GetRoomNumber()} | Status: {room.GetStatus()}");
                }
                else 
                { 
                    Console.WriteLine($"Room Number : {room.GetRoomNumber()} | Status: Occupied.");
                }

            }
            Console.WriteLine("======================================");
        }

        
    }
}
