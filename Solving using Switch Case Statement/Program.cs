using System;
using System.Security.Cryptography.X509Certificates;

namespace Solving_using_Switch_Case_Statement
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Per_Hours = 20;
        static void Main(string[] args)
        {
            int empHrs, empWage;
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
            empWage = empHrs * Emp_Per_Hours;
            Console.WriteLine("Employee Wage : " + empWage);

        }
    }
}
