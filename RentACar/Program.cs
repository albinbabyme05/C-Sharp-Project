


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

            Customer cust1 = new Customer("Arjun", "C001", "9876543210");
            Customer cust2 = new Customer("Neha", "C002", "9123456789");
            Customer cust3 = new Customer("Rahul", "C003", "9988776655");


            renter.DisplayDetails();
            Console.WriteLine("================= ******==================");

            renter.RentedAVehicle("TN22CD5678", 3, cust1);
            renter.RentedAVehicle("KL05IJ7890", 3, cust2);
            renter.RentedAVehicle("KL09QR5678", 3, cust3);

            renter.DisplayDetails();
            Console.WriteLine("================= ******==================");

            renter.RentReport("TN22CD5678");

            Console.WriteLine("====================================== ******=============================================");
            renter.PrintRentReport();
            Console.WriteLine("====================================== ******=============================================");

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
