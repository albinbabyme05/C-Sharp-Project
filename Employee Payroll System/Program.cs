using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee_Payroll_System
{
    public class Program
    {
        static void Main(string[] args)

        {
            PayRollManager users = new PayRollManager();

            FullTimeEmployee e1 = new FullTimeEmployee("Albin", "ALB0510", 5000, 48);
            FullTimeEmployee e2 = new FullTimeEmployee("Aline", "ALI1701", 3000, 30);

            users.AddEmployee(e1);
            users.AddEmployee(e2);

            users.showAllEmployee();
         

        }

    }
}
