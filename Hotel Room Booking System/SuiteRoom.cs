using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room_Booking_System
{
    internal class SuiteRoom : Room
    {
        private double BasePrice = 110;
        public SuiteRoom(string name, int roomNumber, int numberOfGuest, int countStayPerNight) : base(name,roomNumber, numberOfGuest, countStayPerNight)
        {

        }

        public override double CalculateBill()
        {
            if (GetCountStayPerNight() > 5)
            {
                double serviceCharge = 5;
                int extraDay = GetCountStayPerNight() - 5;
                return (BasePrice * GetNumberOfGuest() * GetCountStayPerNight()) + (serviceCharge * extraDay);
            }
            return (BasePrice * GetNumberOfGuest()) * GetCountStayPerNight();

        }
    }

}
