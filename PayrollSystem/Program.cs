using PayrollSystem.Core;
using PayrollSystem.Core.Interface;
using PayrollSystem.Core.Interfaces;
using PayrollSystem.Core.Services;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxCalculator taxCalculator = new TaxCalculator();
            IPayrollService payrollService = new PayrollService(taxCalculator);

            Console.WriteLine("=== Payroll System ===");

            while (true)
            {
                Console.WriteLine("\n1. Add Full-Time Employee");
                Console.WriteLine("2. Add Contract Employee");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddFullTimeEmployee(payrollService);
                        break;
                    case "2":
                        AddContractEmployee(payrollService);
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddFullTimeEmployee(IPayrollService payrollService)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter monthly salary: $");
            if (decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                var employee = new FullTimeEmployee(name, salary);
                payrollService.ProcessPayroll(employee);
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }

        static void AddContractEmployee(IPayrollService payrollService)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter hourly rate: $");
            if (!decimal.TryParse(Console.ReadLine(), out decimal hourlyRate))
            {
                Console.WriteLine("Invalid hourly rate.");
                return;
            }

            Console.Write("Enter hours worked: ");
            if (int.TryParse(Console.ReadLine(), out int hoursWorked))
            {
                var employee = new ContractEmployee(name, hourlyRate, hoursWorked);
                payrollService.ProcessPayroll(employee);
            }
            else
            {
                Console.WriteLine("Invalid hours worked.");
            }
        }
    }
}