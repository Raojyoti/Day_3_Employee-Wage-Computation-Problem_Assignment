using System;
using System.Collections.Generic;
using System.Text;

namespace Save_Total_Wage_for_Each_Company
{
    public class EmpWageBuilder
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public string company ;
        public int empPerHours;
        public int numOfWorkingDays;
        public int maxHrsInMonth;
        public int totalEmpWage;

        public EmpWageBuilder(string company, int empPerHours, int numOfWorkingDays, int maxHrsInMonth) 
        {
            this.company = company;
            this.empPerHours = empPerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
          
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * empPerHours;
            Console.WriteLine("Total Employee Wages for company " + company + " is: " + totalEmpWage);
         
        }
        public string toString()
        {
            return "Total Employee Wage for company  " + this.company + " is: " + this.totalEmpWage;
        }
    }
    
}
