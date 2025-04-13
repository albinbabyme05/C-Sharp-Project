


namespace Hotel_Room_Booking_System
{
    public class Program
    {
        static void Main(string[] args)

        {
            HotelManager manager = new HotelManager();

            StandardRoom guest1 = new StandardRoom("",101, 0, 0);
            StandardRoom guest2 = new StandardRoom("",102, 0, 0);
            DeluxeRoom Dguest1 = new DeluxeRoom("", 103, 0, 0);
            DeluxeRoom Dguest2 = new DeluxeRoom("", 104, 0, 0);
            SuiteRoom Sguest1 = new SuiteRoom("", 105, 0, 0);
            SuiteRoom Sguest2 = new SuiteRoom("", 106, 0, 0);

            manager.AddGuest(guest1);
            manager.AddGuest(guest2);
            manager.AddGuest(Dguest1);
            manager.AddGuest(Dguest2);
            manager.AddGuest(Sguest1);
            manager.AddGuest(Sguest2);


            manager.BookRoom("Musk", 101, 1, 4);
            manager.BookRoom("Gates", 103, 1, 4);
            manager.BookRoom("Ambani", 105, 1, 4);
            manager.BookRoom("jacky", 102, 1, 8);
            manager.BookRoom("lal", 104, 1, 8);
            manager.BookRoom("fahad", 106, 1, 8);

            manager.showAllDetails();

            //manager.ShowAvailableRooms();

            manager.checkout(102);
            manager.checkout(105);

            manager.showAllDetails();

            manager.checkAvailbilty();

            //manager.ShowAvailableRooms();
            

            

        }

    }
}
