using PayrollSystem.Core.Interface;

namespace PayrollSystem.Core.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal grossPay)
        {
            return grossPay * 0.20m;
        }
    }
}