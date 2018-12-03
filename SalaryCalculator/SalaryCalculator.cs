using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    public class Calculator
    {
        int WORK_HOURS_IN_A_YEAR = 2080;

        public decimal GetSalary(decimal hourlyWage)
            => hourlyWage * WORK_HOURS_IN_A_YEAR;

        public decimal GetHourlyWage(decimal annualSalary)
            => annualSalary / WORK_HOURS_IN_A_YEAR;
    }
}
