using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    internal class ContractEmployee : Employee
    {
        private int ProjectCount;
        private double PayPerProject = 0;
        private string Position;

        public ContractEmployee(string name, string id, string position, int projectCount) : base(name, id)
        {
            ProjectCount = projectCount;
            Position = position;
        }


        public override double CalculatePay()
        {
           
            switch (Position)
            {
                case "pm":
                    PayPerProject += (800 * ProjectCount);
                    break;
                case "sd":
                    PayPerProject += (500 * ProjectCount);
                    break;
                case "jd":
                    PayPerProject += (200 * ProjectCount);
                    break;
                default:
                    PayPerProject += 0;
                    break;
            }
            return PayPerProject;
        }
    }
}
/*
pm-project manager
sd = senior developer
jd = junior developer
*/
