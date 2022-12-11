using System;

namespace Manage_Employee_Wage_for_multiple_using_array
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder=new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Capgemini", 20, 2, 20);
            empWageBuilder.addCompanyEmpWage("TCS", 10, 2, 10);
            empWageBuilder.computeEmpWage();


        }
    }
}
