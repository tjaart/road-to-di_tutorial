using System;
using Common;

namespace TheProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Processing Payroll ===");
            var empDb = new EmployeeDatabase();
            var payrollProcessor = new PayrollProcessor();
            payrollProcessor.PayEmployees(empDb.GetEmployees());
        }
    }
}