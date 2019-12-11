using System;
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
            decimal salesMonthly = 161432,
                    salesCommission = salesMonthly * COMMISSION_PERCENTAGE,
                    salesTax = salesCommission * FEDERAL_TAX_PERCENTAGE,
                    retirementDeduction = salesCommission * RETIREMENT_PERCENTAGE,
                    socialSecurityDeduction = salesCommission * SOCIAL_SECURITY_PERCENTAGE,
                    totalDeductions = salesTax + retirementDeduction + socialSecurityDeduction,
                    takeHomePay = salesCommission - totalDeductions;

            WriteLine("{0, 15}{1, 15}", "Employee Name:", employeeName);
            WriteLine("{0, 15}{1, 15:C2}", "Take Home Pay:", takeHomePay);
        }
    }
}
