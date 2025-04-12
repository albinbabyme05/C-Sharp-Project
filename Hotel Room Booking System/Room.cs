using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    internal class Room
    {
        private string RoomStatus;
        public int RoomNumber;
        private string Name;
        private int NumberOfGuest;
        private int CountStayPerNight;
        private double TotalBill= 0;

        //constructor
        public Room(string name, int roomNumber, int numberOfGuest, int countStayPerNight)
        {
            Name = name;
            NumberOfGuest = numberOfGuest;
            CountStayPerNight = countStayPerNight;
            RoomNumber = roomNumber;
            RoomStatus = "Available";
        }
        public void SetNumberOfGuest(int numberOfGuest) { NumberOfGuest = numberOfGuest; }
        public int GetNumberOfGuest() => NumberOfGuest;

        public void SetRoomNumber(int roomNumber) { RoomNumber = roomNumber; }

        public int GetRoomNumber() => RoomNumber;

        public void SetCountStayPerNight(int countStayPerNight) { CountStayPerNight = countStayPerNight; }
        public int GetCountStayPerNight() => CountStayPerNight;

        public void SetStatus(string roomStatus) { RoomStatus = roomStatus;  }
        public string GetStatus() => RoomStatus;

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return;

            Name = name;
        }

        public string GetName() => Name;








        //public string CheckAvailability() { }


        //public string RoomStatus()
        //{

        //}

        //public ChekcoutRoom() { }
        public virtual double CalculateBill()
        {
            return TotalBill;
        }
    }
}
