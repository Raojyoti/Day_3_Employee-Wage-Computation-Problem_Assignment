using System;
using System.Collections.Generic;
using System.Text;

namespace Manage_Employee_Wage_using_interface_approach
{
     public interface IEmpWageBuilderArray
     {
        public void addCompanyEmpWage(string company, int empPerHours, int numOfWorkingDays, int maxHrsInMonth);
        public void computeEmpWage();
     }
    public class CompanyEmpWage
    {
        public string company;
        public int empPerHours;
        public int numOfWorkingDays;
        public int maxHrsInMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empPerHours, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empPerHours = empPerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Employee Wage for company  " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
