using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int TOTAL_WORKING_HRS = 100, TOTAL_WORKING_DAYS = 20, WAGE_PER_HR = 20, FULL_DAY_HR = 8, FULL_TIME = 0, PART_TIME = 1, PART_TIME_HR = 4;
        int empHrs = 0, totalEmpWage = 0, totalEmpHrs = 0;
        public void CalculateEmpWage()
        {
            for (int i = 0; i < TOTAL_WORKING_DAYS && this.empHrs <= TOTAL_WORKING_HRS; i++)
            {
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

            }

            this.totalEmpWage = totalEmpHrs * WAGE_PER_HR;
            Console.WriteLine("Total Employee wage : " + this.totalEmpWage);
        }
    }
}