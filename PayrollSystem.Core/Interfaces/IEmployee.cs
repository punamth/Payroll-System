namespace PayrollSystem.Core
{
    public interface IEmployee
    {
        string Name { get; }
        decimal CalculatePay();
    }
}