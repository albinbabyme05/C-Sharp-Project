using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    internal class FullTimeEmployee : Employee
    {

        public static double OverTimeBonous = 0.2;
        
        public int WorkedHours;
        private double FullTimeEmployeeSalary;
        public FullTimeEmployee(string name, string id, double salary, int workedHours)
            :base(name, id, salary)
        {
            WorkedHours = workedHours;
        }

        public override double CalculatePay()
        {
            if(WorkedHours > 40)
            {
                return GetSalary() * (1 + OverTimeBonous);
            }else if (WorkedHours <= 0)
            {
                Console.WriteLine("Working hours can not be Zero or Negtive");
            }
            return GetSalary();
            
        }
    }
}
