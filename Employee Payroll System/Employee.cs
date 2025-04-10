using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    public class Employee
    {
        public string Name { get; set; }
        private string Id;
        private double Salary;

        public Employee(string name, string id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void SetId(string id) { Id = id; }
        public string GetId() => Id;

        public void SetSalary(double salary)
        {
            if(salary > 5000)
            {
                double taxAmount = 0.1;
                Salary = salary * (1 - taxAmount);
            }
            else if (salary <= 0)
            {
                Console.WriteLine("Salary can not be Negtive or Zero");
            }
            else
            {
                Salary = salary;
            }
                
        }
        public double GetSalary() => Salary;


        public virtual double CalculatePay()
        {
            return Salary;
        }
    }
}
