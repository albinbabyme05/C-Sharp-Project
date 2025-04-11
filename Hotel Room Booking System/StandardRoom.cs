using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    internal class StandardRoom : Room
    {
        private double BasePrice = 60;
        public StandardRoom(string name, int numberOfGuest, int countStayPerNight) : base(name, numberOfGuest, countStayPerNight)
        {

        }

        public override double CalculateBill()
        {
            if (GetCountStayPerNight() > 5)
            {
                double serviceCharge = 1.5;
                int extraDay = GetCountStayPerNight() - 5;
                return (BasePrice * GetNumberOfGuest() * GetCountStayPerNight()) + (serviceCharge * extraDay);
            }
            return (BasePrice * GetNumberOfGuest()) * GetCountStayPerNight();
        }
    }
            
    
}
