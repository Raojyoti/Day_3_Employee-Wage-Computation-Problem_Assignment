using System;

namespace Calculate_Daily_Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            int Emp_Per_Hours = 20;
            int empHrs , empWage;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Per_Hours;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
