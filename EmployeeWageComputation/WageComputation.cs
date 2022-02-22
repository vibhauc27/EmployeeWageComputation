using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class WageComputation
    {
        const int EMP_PRESENT = 0, EMP_ABSENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is present");
                int dailyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
                Console.WriteLine(dailyEmpWage);
            }
            if (empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}