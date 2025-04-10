using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inventory_System
{
    internal class Clothings : Items
    {
        public  Clothings(string name, decimal price, int quantity) : base(name, price, quantity)
        {

        }

        public override decimal CalculateDiscountPrice()
        {
            decimal off = 0.2m;
            if (GetQuantity() > 3)
            {
                return GetPrice() * GetQuantity() * (1 - off);
            }
            return GetPrice() * GetQuantity();
        }
    }
}
