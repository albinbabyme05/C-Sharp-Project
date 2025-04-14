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

<<<<<<< HEAD
=======
        // print records
        private List<RentalRecord> rentalHistory = new List<RentalRecord>();


>>>>>>> rentAcar
        public void AddVehicle(Vehicle vehicle)
        {
            kart.Add(vehicle);
        }

       
        public void RentedAVehicle(string vehicle_id, int numberOfDaysRented, Customer customer)
        {
            foreach (var vehicle in kart)
            {
                if (vehicle.GetVehicleId() == vehicle_id)
                {
                    vehicle.SetStatus("Rented");
                    vehicle.SetRentedDay(numberOfDaysRented);

                    Console.WriteLine($"vechile {vehicle.GetModel()} Id: {vehicle.GetVehicleId()} Rented ");


                    RentalRecord r1 = new RentalRecord(customer, vehicle);
                    rentalHistory.Add(r1);

                    Console.WriteLine($"vechile {vehicle.GetModel()} Id: {vehicle.GetVehicleId()} Rented to {customer.GetName()} ");

                    Console.WriteLine("==========================================================================");
                    return;
                }
                
            }
        }

        public void DisplayDetails()
        {
            foreach (var vehicle in kart)
            {
                if (vehicle.GetStatus() == "Available")
                {
                    Console.WriteLine($"vechileId: {vehicle.GetVehicleId()} - Brand: {vehicle.GetBrand()}  - Model: {vehicle.GetModel()} - Status: {vehicle.GetStatus()} ");
                    
                }
                else
                {
                    Console.WriteLine($"vechileId: {vehicle.GetVehicleId()}  - Brand: {vehicle.GetBrand()} - Model: {vehicle.GetModel()} - Status: Rented ");
                    
                }
            }
            Console.WriteLine("==========================================================================");
        }

        public void Return(string vehicleId)
        {
            foreach (var vehicle in kart)
            {
                if(vehicle.GetVehicleId() == vehicleId)
                {
                    vehicle.SetStatus("Available");
                    Console.WriteLine($"vechile {vehicle.GetModel()} Id: {vehicle.GetVehicleId()} Available Now ");
                    Console.WriteLine("==========================================================================");
                    return;
                }
            }
        }

        public void RentReport(string vechicleId)
        {
            foreach (var vehicle in kart)
            {
                if (vehicle.GetVehicleId() == vechicleId && vehicle.GetStatus() == "Rented")
                {

                    Console.WriteLine($"vechileId: {vehicle.GetVehicleId()} - Model: {vehicle.GetModel()} - Rented for: {vehicle.GetRentedDay()} Days -  RentAmount: {vehicle.CalculateRent(vehicle.GetVehicleId())} ");
                }
                else if (vehicle.GetVehicleId() == vechicleId && vehicle.GetStatus()== "Available")

                    Console.WriteLine($" vechileId: {vehicle.GetVehicleId()} - Model: {vehicle.GetModel()} - Rented for: {vehicle.GetRentedDay()} Days -  RentAmount: {vehicle.CalculateRent(vehicle.GetVehicleId())} ");
                }
                else if (vehicle.GetVehicleId() == vechicleId && vehicle.GetStatus() == "Available")

                {
                    Console.WriteLine($"vechileId: {vehicle.GetVehicleId()} - Model: {vehicle.GetModel()} is Not Rented ");
                }
            }
        }

        public void PrintRentReport()
        {
            foreach (var record in rentalHistory)
            {
                Console.WriteLine(record.PrintReport());
            }
        }
    }
}
