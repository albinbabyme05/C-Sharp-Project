using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Truck : Vehicle
    {
        private double BaseRate;
        private double DailyRate;
        public Truck(string vehicleId, string model, string brand) : base(vehicleId, model, brand)
        {
            BaseRate = 60;
            DailyRate = 20;
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
