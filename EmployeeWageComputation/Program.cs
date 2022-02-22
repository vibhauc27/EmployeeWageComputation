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
            WageComputation wagecomputation = new WageComputation();
            wagecomputation.GetData();            
        }
    }
}