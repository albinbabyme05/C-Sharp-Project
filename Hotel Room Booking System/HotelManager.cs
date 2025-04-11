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

        public void showAllDetails()
        {
            Console.WriteLine("<=== Hotel Moxy International ===>");
            foreach (var guest in chart)
            {
                Console.WriteLine($"Name: {guest.GetName()}| GuestCount: {guest.GetNumberOfGuest()} |" +
                    $" NumberOfday: {guest.GetCountStayPerNight()}| total: {guest.CalculateBill()} ");
            }
        }
    }
}
