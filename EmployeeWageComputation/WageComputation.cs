using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string companyName;
        private int empWagePerHour;
        private int workingDays;
        private int maxHours;
        private int totalEmpWage;

        public WageComputation(string companyName, int empWagePerHour, int workingDays, int maxHours)
        {
            this.companyName = companyName;
            this.empWagePerHour = empWagePerHour;
            this.workingDays = workingDays;
            this.maxHours = maxHours;
        }

        public void computeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this.maxHours && totalWorkingDays < this.workingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp Hours:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empWagePerHour;
        }

        public string toString()
        {
            return "Total Emp Wage For Company : " + this.companyName + " is " + this.totalEmpWage;
        }

    }
}