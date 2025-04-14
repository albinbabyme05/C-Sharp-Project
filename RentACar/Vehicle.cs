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
        private string Status;
  
        

        public Vehicle(string vehicleId, string model, string brand)
        {
            VehicleId = vehicleId;
            Model = model;
            Brand = brand;
            RentRate = 0;
            Status = "Available";
        }

        public void SetStatus(string status) { Status = status; }
        public string GetStatus() => Status;

        public string GetVehicleId() => VehicleId;

        public void SetModel(string model) { Model = model; }
        public string GetModel() => Model;

        public void SetBrand(string brand) { Brand = brand; }
        public string GetBrand() => Brand;


        public abstract double CalculateRent(int days);
        public  void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model} - VechileId: {VehicleId} - Brand: {Brand} ");
        }
        



    }
}
