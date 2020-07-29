using System;
using AbstractedCommon;
using Common;
using TheProblem;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Processing Payroll ===");
            var empDb = new EmployeeDatabase();
            var payrollProcessor = new PayrollProcessorInverted(new PaymentProcessorFactory());
            payrollProcessor.PayEmployees(empDb.GetEmployees());
        }
    }
}