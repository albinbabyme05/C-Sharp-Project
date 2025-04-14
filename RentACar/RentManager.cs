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

       
        public void RentedAVehicle(string vehicle_id)
        {
            foreach (var item in kart)
            {
                if (item.GetVehicleId() == vehicle_id)
                {
                    item.SetStatus("Rented");
                    Console.WriteLine($"vechile {item.GetModel()} Id: {item.GetVehicleId()} Rented ");
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
        }

        
        //public void RentReport(string vechicleId)
        //{
        //    foreach (var item in kart)
        //    {
        //        if (item.GetVehicleId() == vechicleId)
        //        {
        //            Console.WriteLine($"vechile {item.GetModel()} Model: {item.GetModel()} Id: {item.GetVehicleId()} Status: {item.CalculateRent()} ");
        //        }
        //    }
        //}
    }
}
