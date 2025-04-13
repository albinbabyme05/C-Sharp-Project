using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public abstract class Vehicle
    {
        //fields
        protected string VehicleId;
        protected string Model;
        protected string Brand;
        protected double RentRate;
        public bool IsAvailble;
  
        

        public Vehicle(string vehicleId, string model, string brand)
        {
            VehicleId = vehicleId;
            Model = model;
            Brand = Brand;
            RentRate = 0;
            IsAvailble = true;
        }

        public abstract double CalculateRent(int days);
        public  void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model} - VechileId: {VehicleId} - Brand: {Brand} ");
        }
        



    }
}
