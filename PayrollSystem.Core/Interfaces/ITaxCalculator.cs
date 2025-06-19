namespace PayrollSystem.Core.Interface
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal income);
    }
}