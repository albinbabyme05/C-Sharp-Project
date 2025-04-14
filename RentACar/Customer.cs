using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Customer
    {
        
        private string Name;
        private string Phone;
        private string CustomerId;

        public Customer(string name, string customerId, string contact)
        {
            Name = name;
            Phone = contact;
            CustomerId = customerId;
        }

        public void SetName(string name) { Name = name;  }
        public string GetName() => Name;
        public void SetPhone(string phone) { Phone = phone; }
        public string GetPhone() => Phone;


        public void DisplayCustomer()
        {
            Console.WriteLine($"Name : {Name} - Id: {CustomerId} - Phone: {Phone}");
        }
    }
}
