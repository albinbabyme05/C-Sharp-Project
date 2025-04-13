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
  
        

        public Vehicle(string vehicleId, string model)
        {
            VehicleId = vehicleId;
            Model = model;
            Brand = Brand;
            RentRate = 0;


            
        }

        public abstract double CalculateRent(int days);
        public  void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model} - VechileId: {VehicleId} - NumberPlate: {NumberPlate} - Status: {Is} ");
        }
        public 



    }
}
