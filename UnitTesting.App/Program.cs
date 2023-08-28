
using SW.Payroll;
using System.Diagnostics;

namespace UnitTesting.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1000,
                Name = "Reem A.",
                DutyStation = "Montreal",
                IsMarried = true,
                TotalDependancies = 2,
                Wage = 910m,
                WorkingDays = 22,
                IsDanger = true,
                HasPensionPlan = true,
                HealthInsurancePackage = HealthInsurancePackage.Basic,
                WorkPlatform = WorkPlatform.Hybrid
            };

            var salarySlipProcessor = new SalarySlipProcessor(null);
            var empSalarySlip = salarySlipProcessor.Process(employee);
            Console.WriteLine(empSalarySlip);
            Console.ReadKey();

        }
        
    }
}