namespace PayrollSystem.Core.Interfaces
{
    public interface IPayrollService
    {
        void ProcessPayroll(IEmployee employee);
    }
}