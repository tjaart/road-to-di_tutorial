using AbstractedCommon;
using Abstractions;
using Common;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IPaymentProcessorFactory, PaymentProcessorFactory>();
            services.AddTransient<IPayrollProcessor, ServiceLocatorPayrollProcessor>();
            services.AddTransient<IEmployeeDatabase, EmployeeDatabase>();
            
            var provider = services.BuildServiceProvider();

            var db = provider.GetService<IEmployeeDatabase>();

            var payrollProcessor = provider.GetService<IPayrollProcessor>();
            
            payrollProcessor.PayEmployees(db.GetEmployees());
        }
    }
}