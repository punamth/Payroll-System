using PayrollSystem.Core.Interface;
using PayrollSystem.Core.Interfaces;

namespace PayrollSystem.Core.Services
{
    public class PayrollService : IPayrollService
    {
        private readonly ITaxCalculator _taxCalculator;

        public PayrollService(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void ProcessPayroll(IEmployee employee)
        {
            decimal grossPay = employee.CalculatePay();
            decimal tax = _taxCalculator.CalculateTax(grossPay);
            decimal netPay = grossPay - tax;

            Console.WriteLine($"Employee: {employee.Name}");
            Console.WriteLine($"Gross Pay: ${grossPay:F2}");
            Console.WriteLine($"Tax: ${tax:F2}");
            Console.WriteLine($"Net Pay: ${netPay:F2}");
            Console.WriteLine("-------------------");
        }
    }
}