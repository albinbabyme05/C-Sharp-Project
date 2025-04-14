


using RentACar;

namespace Hotel_Room_Booking_System
{
    public class Program
    {
        static void Main(string[] args)

        {
            RentManager renter = new RentManager();

            Car c1 = new Car("KL57N5968", "Swift", "Maruthi");
            Car c2 = new Car("TN22CD5678", "i20", "Hyundai");
            Car c3 = new Car("MH12EF9012", "Jazz", "Honda");
            Car c4 = new Car("KA05GH3456", "Altroz", "Tata");
            Car c5 = new Car("KL01AB1234", "Baleno", "Maruti");

            renter.AddVehicle(c1);
            renter.AddVehicle(c2);
            renter.AddVehicle(c3);
            renter.AddVehicle(c4);
            renter.AddVehicle(c5);

            renter.RentedAVehicle("TN22CD5678");
            renter.RentedAVehicle("KA05GH3456");

            renter.DisplayDetails();

            




        }

    }
}
