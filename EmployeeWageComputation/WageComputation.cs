using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int TOTAL_WORKING_HRS = 100, TOTAL_WORKING_DAYS = 20, WAGE_PER_HR = 20, FULL_DAY_HR = 8, FULL_TIME = 0, PART_TIME = 1, PART_TIME_HR = 4;
        public static int CalculateEmpWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = FULL_DAY_HR;
                        break;
                    case PART_TIME:
                        empHrs = PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + " Emp Hours : " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * WAGE_PER_HR;
            Console.WriteLine("Total Employee wage : " + totalEmpWage);
            return totalEmpWage;
        }
        public void GetData()
        {
            Console.Write("Enter Company Name : ");
            string companyName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Emp Wage Per Hour : ");
            int empWagePerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No. of Working Days : ");
            int workingDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Max Working Hours Per Month : ");
            int maxHours = Convert.ToInt32(Console.ReadLine());

            CalculateEmpWage(companyName, empWagePerHour, workingDays, maxHours);
        }
    }
}