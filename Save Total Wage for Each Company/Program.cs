using System;

namespace Save_Total_Wage_for_Each_Company
{
    public class Program
    {
       public static void Main(string[] args)
        {
            EmpWageBuilder obj = new EmpWageBuilder("TCS", 20, 5, 50);
            EmpWageBuilder obj1 = new EmpWageBuilder("Capgemini", 20, 10, 100);
            obj.computeEmpWage();
            Console.WriteLine(obj.toString());
            Console.Write("\n");
            obj1.computeEmpWage();
            Console.WriteLine(obj1.toString());
        }
    }
}
