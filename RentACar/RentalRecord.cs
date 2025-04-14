using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class RentalRecord
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle{ get; set; }

        // constructor
        public RentalRecord(Customer customer, Vehicle vehicle)
        {
            Customer = customer;
            Vehicle = vehicle;
        }

        public string PrintReport()
        {
            return $"{Customer.GetName()} || {Customer.GetPhone()} || {Vehicle.GetVehicleId()} || {Vehicle.GetModel()} || " +
                $" {Vehicle.CalculateRent(Vehicle.GetVehicleId())} Euro for {Vehicle.GetRentedDay()} Days ";
        }
    }
}
