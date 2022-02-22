using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, FULL_TIME = 0, PART_TIME = 1, EMP_ABSENT = 2, PART_TIME_HR = 4;
        int empHrs = 0, totalEmpWage = 0;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
                this.totalEmpWage = empHrs * WAGE_PER_HR;
                Console.WriteLine("Total FullTime Employee wage : " + this.totalEmpWage);
            }
            if (empCheck == PART_TIME)
            {
                empHrs = PART_TIME_HR;
                this.totalEmpWage = empHrs * WAGE_PER_HR;
                Console.WriteLine("Total PartTime Employee wage : " + this.totalEmpWage);
            }
            if (empCheck == EMP_ABSENT)
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
                this.totalEmpWage = empHrs * WAGE_PER_HR;
                Console.WriteLine("Total Employee wage : " + this.totalEmpWage);
            }
        }
    }
}