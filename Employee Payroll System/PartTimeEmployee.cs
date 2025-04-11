using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    internal class PartTimeEmployee : Employee
    {
        private double baseSalary = 0;
        private int WorkedHours;
        private double HourlyRate = 14;
        private  double taxAmount = 0.35;
        private string Position; 

        public PartTimeEmployee(string name, string id, string position,int workedHours) : base(name, id)
        {
            WorkedHours = workedHours;
            Position = position;

        }

        public int GetWorkedHours() => WorkedHours;

        public void SetWorkHours(int workedHours, string position)
        {
            if(position=="intern" && workedHours > 160)
            {
                WorkedHours = 160;
            }
            else if (position == "ws" && workedHours > 80)
            {
                WorkedHours = 80;
            }
            
        }

        public int GetWokedHours() => WorkedHours;
        
        public override double CalculatePay()

        {
            double salary = baseSalary;
            switch (Position)
            {
                case "intern":
                    salary += HourlyRate * GetWokedHours() * (1-taxAmount);
                    Console.WriteLine($"worked hours: {HourlyRate}, getworked: {GetWokedHours()}, salary : {salary}");
                    break;
                case "ws":
                    salary += HourlyRate * GetWokedHours();
                    Console.WriteLine($"worked hours: {HourlyRate}, getworked: {GetWokedHours()}, salary : {salary}");
                    break;
                default:
                    break;
            }
            Console.WriteLine($"worked hours: {HourlyRate}, getworked: {GetWokedHours()}, salary : {salary}");
            return salary;
            
        }
    }
}
