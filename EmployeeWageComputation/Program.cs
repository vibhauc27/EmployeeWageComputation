using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter How Many Companies you want to add : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                Console.Write("Enter Company Name                : ");
                string companyName = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Emp Wage Per Hour           : ");
                int empWagePerHour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter No. of Working Days         : ");
                int workingDays = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Max Working Hours Per Month : ");
                int maxHours = Convert.ToInt32(Console.ReadLine());
                WageComputation company = new WageComputation(companyName, empWagePerHour, workingDays, maxHours);
                company.computeEmpWage();
                Console.WriteLine(company.toString());
                Console.WriteLine("\n");
                num--;
            }
            Console.ReadLine();
        }
    }
}