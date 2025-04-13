using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Car : Vehicle
    {
        private double BaseRate;
        private double DailyRate;
        public Car(string vehicleId, string model, string brand):base(vehicleId, model, brand)
        {
             BaseRate = 35.4;
             DailyRate = 12.3;
        }
        public override double CalculateRent(int days)
        {
            return BaseRate + DailyRate;
        }
    }
}
