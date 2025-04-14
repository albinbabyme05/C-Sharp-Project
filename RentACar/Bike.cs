using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Bike : Vehicle
    {
        private double BaseRate;
        private double DailyRate;
        public Bike(string vehicleId, string model, string brand) : base(vehicleId, model, brand)
        {
            BaseRate = 25;
            DailyRate = 8;
        }
        public override double CalculateRent(string vehicleId)
        {

            if (vehicleId == GetVehicleId() && GetStatus() == "Rented")
            {
                
                return BaseRate + (DailyRate * GetRentedDay());
            }
            else
            {
                return 0.0;
            }

        }
    }
}
