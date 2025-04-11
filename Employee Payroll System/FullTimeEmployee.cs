using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    internal class FullTimeEmployee : Employee
    {

        private double BaseSalary = 4500;
        private string Position { get; set; }
        private int Hours { get; set; }
        private double OverTimeBonus = 0.2;
        private double TaxC1 = 0.5;

        
        public FullTimeEmployee(string name, string id,string position, int hours): base(name, id)
        {
            Hours = hours;
            Position = position;
        }

        public double GetBaseSalary() => BaseSalary;
        public void SetBaseSalary() { BaseSalary = 4500; }
        
        public override double CalculatePay()
        {
            double salary = BaseSalary;
            switch (Position)
            {
                case "manager":
                    salary += 1500;
                    break;
                case "teamlead":
                    salary += 1000;
                    break;
                case "engineer":
                    salary += 500;
                    break;
                default:
                    salary += 0;
                    break;
            }

            if (Hours > 160)
            {
                salary += (Hours - 160) * OverTimeBonus;
            }

            if (salary > 8000)
            {
                salary *= (1-TaxC1);
                return salary;
            }
            return salary;
        }
    }
}
