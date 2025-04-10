using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inventory_System
{
    public class Items
    {
        private string Name { get; set; }
        private decimal Price { get; set; }
        private int Quantity { get; set; }

        public Items(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void SetName(string name)
        {
            Name = name;

        }
        public string GetName()
        {
            return Name;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }
        public decimal GetPrice()
        {
            return Price;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public int GetQuantity()
        {
            return Quantity;
        }

        public virtual decimal CalculateDiscountPrice()
        {
            return Price * Quantity;    
        }
        

        

    }
}
