using System;

namespace Calculating_Wages_for_a_Month
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Per_Hours = 20;
        public const int Num_Of_Working_Days = 20;
        static void Main(string[] args)
        {
            int empHrs=0, empWage=0, totalEmpWage=0;
            Random random = new Random();
            int check = random.Next(0, 3);
            for (int day = 1; day <=Num_Of_Working_Days; day++)
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
                empWage = empHrs * Emp_Per_Hours;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wages : " + totalEmpWage);
        }
    }
}
