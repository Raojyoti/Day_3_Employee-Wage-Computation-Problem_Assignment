using System;

namespace Refactor_the_Code
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Per_Hours = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 10;
        public static int computeEmpWage() 
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
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
            int totalEmpWage = totalEmpHrs * Emp_Per_Hours;
            Console.WriteLine("Total Employee Wages : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}
