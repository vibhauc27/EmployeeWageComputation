using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class CompanyEmpWage
    {
        public string companyName;
        public int empWagePerHour;
        public int workingDays;
        public int maxHours;
        public int totalEmpWage;

        public CompanyEmpWage(string companyName, int empWagePerHour, int workingDays, int maxHours)
        {
            this.companyName = companyName;
            this.empWagePerHour = empWagePerHour;
            this.workingDays = workingDays;
            this.maxHours = maxHours;
        }

        public void setTotalEmpwage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for Company :" + this.companyName + " is " + this.totalEmpWage;
        }
    }
}