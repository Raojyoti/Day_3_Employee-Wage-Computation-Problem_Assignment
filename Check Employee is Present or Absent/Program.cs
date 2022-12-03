using System;

namespace Check_Employee_is_Present_or_Absent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            Random random= new Random();
            int check = random.Next(0,2);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else 
            { 
                Console.WriteLine("Employee is Absent");
            }
         
        }
    }
}
