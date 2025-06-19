namespace PayrollSystem.Core.Interfaces
{
    public class ContractEmployee : IEmployee
    {
        public string Name { get; }
        public decimal HourlyRate { get; }
        public int HoursWorked { get; }
        public ContractEmployee(string name, decimal hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        public decimal CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }
    }
}