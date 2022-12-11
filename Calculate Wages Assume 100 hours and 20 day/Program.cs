using System;

namespace Calculate_Wages_Assume_100_hours_and_20_day
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Per_Hours = 20;
        public const int Num_Of_Working_Days =20;
        public const int Max_Hrs_In_Month = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            totalWorkingDays++;
            Random random = new Random();
            int check = random.Next(0, 3);
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
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
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs );
            }
            int totalEmpWage = totalEmpHrs * Emp_Per_Hours;
            Console.WriteLine("Total Employee Wages : " + totalEmpWage);
        }
    }
}
