using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class RentManager

    {
        public bool IsAvailable=true;
        private List<Vehicle> kart = new List<Vehicle>();

        public void AddVehicle(Vehicle item)
        {
            kart.Add(item);
        }

       
        public void RentedAVehicle(string vehicle_id, int numberOfDaysRented)
        {
            foreach (var item in kart)
            {
                if (item.GetVehicleId() == vehicle_id)
                {
                    item.SetStatus("Rented");
                    item.SetRentedDay(numberOfDaysRented);
                    Console.WriteLine($"vechile {item.GetModel()} Id: {item.GetVehicleId()} Rented ");
                    Console.WriteLine("==========================================================================");
                    return;
                }
                
            }
        }

        public void DisplayDetails()
        {
            foreach (var item in kart)
            {
                if (item.GetStatus() == "Available")
                {
                    Console.WriteLine($"vechileId: {item.GetVehicleId()} - Brand: {item.GetBrand()}  - Model: {item.GetModel()} - Status: {item.GetStatus()} ");
                    
                }
                else
                {
                    Console.WriteLine($"vechileId: {item.GetVehicleId()}  - Brand: {item.GetBrand()} - Model: {item.GetModel()} - Status: Rented ");
                    
                }
            }
            Console.WriteLine("==========================================================================");
        }

        public void Return(string vehicleId)
        {
            foreach (var item in kart)
            {
                if(item.GetVehicleId() == vehicleId)
                {
                    item.SetStatus("Available");
                    Console.WriteLine($"vechile {item.GetModel()} Id: {item.GetVehicleId()} Available Now ");
                    Console.WriteLine("==========================================================================");
                    return;
                }
            }
        }

        public void RentReport(string vechicleId)
        {
            foreach (var item in kart)
            {
                if (item.GetVehicleId() == vechicleId && item.GetStatus() == "Rented")
                {
                    Console.WriteLine($"vechileId: {item.GetVehicleId()} - Model: {item.GetModel()} - Rented for: {item.GetRentedDay()} Days -  RentAmount: {item.CalculateRent(item.GetVehicleId())} ");
                }
                else if (item.GetVehicleId() == vechicleId && item.GetStatus()== "Available")
                {
                    Console.WriteLine($"vechileId: {item.GetVehicleId()} - Model: {item.GetModel()} is Not Rented ");
                }
            }
        }
    }
}
