


using RentACar;

namespace Hotel_Room_Booking_System
{
    public class Program
    {
        static void Main(string[] args)

        {
            RentManager renter = new RentManager();

            // Car c1 = new Car("KL57N5968", "Swift", "Maruthi");
            renter.AddVehicle(new Car("KL57N5968", "Swift", "Maruthi"));
            renter.AddVehicle(new Car("TN22CD5678", "i20", "Hyundai"));
            renter.AddVehicle(new Bike("KL05IJ7890", "Pulsar", "Bajaj"));
            renter.AddVehicle(new Bike("KL06KL2345", "Splendor", "Hero"));
            renter.AddVehicle(new Truck("KL09QR5678", "Eicher Pro", "Eicher"));
            renter.AddVehicle(new Truck("KL10ST9012", "Prima", "Tata"));

            renter.DisplayDetails();
            Console.WriteLine("================= ******==================");

            renter.RentedAVehicle("TN22CD5678", 3);
            renter.RentedAVehicle("KL05IJ7890", 3);
            renter.RentedAVehicle("KL09QR5678", 3);

            renter.DisplayDetails();
            Console.WriteLine("================= ******==================");

            renter.RentReport("TN22CD5678");
            renter.RentReport("KL05IJ7890");
            renter.RentReport("KL09QR5678");
            renter.Return("TN22CD5678");
            
            Console.WriteLine("===================================");

            renter.Return("KL09QR5678");
            renter.Return("KL05IJ7890");
            renter.DisplayDetails();
            Console.WriteLine("================= ******==================");


            renter.RentReport("KL10ST9012");





        }

    }
}
