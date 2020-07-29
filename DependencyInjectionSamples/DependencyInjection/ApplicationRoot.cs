using Abstractions;
using Common;

namespace DependencyInjection
{
    internal class ApplicationRoot : IApplicationRoot
    {
        private readonly IEmployeeDatabase _employeeDatabase;
        private readonly IPayrollProcessor _payrollProcessor;

        public ApplicationRoot(IEmployeeDatabase employeeDatabase, IPayrollProcessor payrollProcessor)
        {
            _employeeDatabase = employeeDatabase;
            _payrollProcessor = payrollProcessor;
        }
        
        public void Run()
        {
            _payrollProcessor.PayEmployees(_employeeDatabase.GetEmployees());
        }
    }
}