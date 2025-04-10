

namespace Basic_Inventory_System
{
    class Program
    {

        static void Main(string[] args)
        {
            

            InventoryManager manager = new InventoryManager();

            Electronics electronics = new Electronics("Laptop", 1200, 2);
            Grocery grocery = new Grocery("Soap", 12,20);
            Clothings cloths = new Clothings("Jeans", 29, 5);
            Electronics mobile = new Electronics("Iphone 16", 1020, 1);
            Electronics mobile2 = new Electronics("Iphone 15", 820, 1);

            manager.AddItem(electronics);
            manager.AddItem(grocery);
            manager.AddItem(cloths);
            manager.AddItem(mobile);
            manager.AddItem(mobile2);

            manager.ShowAllItem();

            manager.GetTotal();

            Console.WriteLine("===========================");

            manager.RemoveItem(mobile2);

            Console.WriteLine("===========================");
            manager.ShowAllItem();
            manager.GetTotal();

            
        }
    }
}

