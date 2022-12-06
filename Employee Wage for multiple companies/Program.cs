using System;

namespace Employee_Wage_for_multiple_companies
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public static int computeEmpWage(string company, int empPerHours, int numOfWorkingDays, int maxHrsInMonth)
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
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("TCS", 20, 2, 10);
            computeEmpWage("Capgemini", 20, 4, 10);
        }
    }
}
