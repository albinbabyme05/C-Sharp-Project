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

            FullTimeEmployee e1 = new FullTimeEmployee("Albin", "ALB0510", "engineer",180);
            FullTimeEmployee e2 = new FullTimeEmployee("Aline", "ALI1701", "engineer",150);

            users.AddEmployee(e1);
            users.AddEmployee(e2);

            //// adding part time employee

            PartTimeEmployee p1 = new PartTimeEmployee("Angel", "ANG1701", "intern", 160);
            PartTimeEmployee p2 = new PartTimeEmployee("Amal", "AMA2703", "ws", 80);
          
            users.AddEmployee(p1);
            users.AddEmployee(p2);
            

            // adding contract employee

            ContractEmployee c1 = new ContractEmployee("Thomas", "THO1604", "pm", 8);
            ContractEmployee c2 = new ContractEmployee("Diveesh", "DIV2303", "pm", 4);
            ContractEmployee c3 = new ContractEmployee("Akhil", "AKH2705", "sd", 4);
            ContractEmployee c4 = new ContractEmployee("Dennis", "DEN2303", "jd", 4);

            users.AddEmployee(c1);
            users.AddEmployee(c2);
            users.AddEmployee(c3);
            users.AddEmployee(c4);


            users.showAllEmployee();
         

        }

    }
}
