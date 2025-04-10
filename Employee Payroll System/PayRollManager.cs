using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_System
{
    internal class PayRollManager
    {
        private List<Employee> payReports = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            payReports.Add(employee);
        }

        public void showAllEmployee()
        {
            foreach (var employe in payReports)
            {
                Console.WriteLine($"Name: {employe.Name} | Id: {employe.GetId()} |" +
                    $" Base Salary: {employe.GetSalary()} | Total: {employe.CalculatePay()} ");
                Console.WriteLine("=========================================================");
            }
        }
    }
}
