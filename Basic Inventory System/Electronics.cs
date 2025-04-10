using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Inventory_System
{
    public class Electronics : Items
    {
        
        public Electronics(string name, decimal price, int quantity) : base (name, price, quantity)
        {
            
        }

        public override decimal CalculateDiscountPrice()
        {
            decimal off = 0.2m;
            if (GetPrice() > 500)
            {
                return GetPrice() * GetQuantity() * (1 - off);
            }
            return GetPrice() * GetQuantity();
        }
    }
}
