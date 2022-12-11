using System;

namespace Manage_Employee_Wage_using_interface_approach
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Capgemini", 20, 5, 80);
            empWageBuilder.addCompanyEmpWage("TCS", 10, 8, 50);
            empWageBuilder.computeEmpWage();
        }
    }
}
