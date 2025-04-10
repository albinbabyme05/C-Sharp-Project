using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inventory_System
{
    internal class InventoryManager
    {
        private List<Items> kart = new List<Items>();

        public void AddItem(Items item)
        {
            kart.Add(item);
        }

        public void ShowAllItem()
        {
            foreach (var item in kart)
            {
                Console.WriteLine($"Name: {item.GetName()} | Nos: {item.GetQuantity()} | Price: {item.GetPrice()} | Discounted Price: {item.CalculateDiscountPrice()} ");
            }
        }

        public void GetTotal()
        {
            decimal total = 0;
            foreach (var item in kart)
            {
                total += item.CalculateDiscountPrice();
            }
            Console.WriteLine("Total bill amount = "+total+ " Euro");
        }

        public void RemoveItem(Items item)
        {
            if (kart.Contains(item))
            {
                kart.Remove(item);
            }
            else
            {
                Console.WriteLine($"{item} is not found in the list");
            }
        }
    }
}
