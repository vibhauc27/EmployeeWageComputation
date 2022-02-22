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

        public int noOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public WageComputation()//EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string companyName, int empWagePerHour, int workingDays, int maxHours)
        {
            companyEmpWageArray[this.noOfCompany] = new CompanyEmpWage(companyName, empWagePerHour, workingDays, maxHours);
            noOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpwage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHours && totalWorkingDays < companyEmpWage.workingDays)
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
            return totalEmpHrs * companyEmpWage.empWagePerHour;
        }

    }
}