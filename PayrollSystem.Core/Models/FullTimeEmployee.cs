namespace PayrollSystem.Core.Interfaces
{
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public FullTimeEmployee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public decimal CalculatePay()
        {
            return Salary; 
        }
    }
}