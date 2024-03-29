﻿using System;
using static System.Console;

namespace take_home_pay
{
    class Program
    {
        static void Main(string[] args)
        {
            // all calculations in compile-time initializations, per spec
            string employeeName = "Joshua Montain";
            const decimal COMMISSION_PERCENTAGE = 0.07M,
                          FEDERAL_TAX_PERCENTAGE = 0.18M,
                          RETIREMENT_PERCENTAGE = 0.1M,
                          SOCIAL_SECURITY_PERCENTAGE = 0.06M;
            decimal salesMonthly = 1300000,
                    salesCommission = salesMonthly * COMMISSION_PERCENTAGE,
                    salesTax = salesCommission * FEDERAL_TAX_PERCENTAGE,
                    retirementDeduction = salesCommission * RETIREMENT_PERCENTAGE,
                    socialSecurityDeduction = salesCommission * SOCIAL_SECURITY_PERCENTAGE,
                    totalDeductions = salesTax + retirementDeduction + socialSecurityDeduction,
                    takeHomePay = salesCommission - totalDeductions;

            WriteLine("{0, 18}{1, 16}", "Employee Name:", employeeName);
            WriteLine("{0, 18}{1, 16:C2}", "Monthly sales:", salesMonthly);
            WriteLine("{0, 18}{1, 16:N2}", "Commission:", salesCommission);
            WriteLine("{0, 18}{1, 16:N2}", "Federal Tax:", salesTax);
            WriteLine("{0, 18}{1, 16:N2}", "Retirement:", retirementDeduction);
            WriteLine("{0, 18}{1, 16:N2}", "Social Security:", socialSecurityDeduction);
            WriteLine("{0, 18}{1, 16:N2}", "Total Deductions:", totalDeductions);
            WriteLine("{0, 18}{1, 16:C2}", "Take Home Pay:", takeHomePay);
        }
    }
}
