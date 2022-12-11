using System;
using System.Collections.Generic;
using System.Text;
using static Manage_Employee_Wage_using_interface_approach.IEmpWageBuilderArray;

namespace Manage_Employee_Wage_using_interface_approach
{
    public class EmpWageBuilderArray : IEmpWageBuilderArray
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        private int numOfCompany = 0;

        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empPerHours, int numOfWorkingDays, int maxHrsInMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empPerHours, numOfWorkingDays, maxHrsInMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHrsInMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case Full_Time:
                        empHrs = 8;
                        break;
                    case Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empPerHours;
        }
    }
}
