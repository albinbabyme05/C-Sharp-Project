using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        

        public Employee(string name, string id)
        {
            Name = name;
            Id = id;
        }



        public abstract double CalculatePay();
 
    }
}
