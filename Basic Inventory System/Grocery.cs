using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inventory_System
{
    internal class Grocery : Items
    {
        public Grocery(string name, decimal price, int quantity) : base(name, price, quantity)
        {

        }

        public override decimal CalculateDiscountPrice()
        {
            decimal off = 0.05m;
            
            return GetPrice() * GetQuantity() * (1 - off);
            
        }
    }
}
