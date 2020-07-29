using System.Collections.Generic;
using AbstractedCommon;
using Abstractions;
using Common;

namespace DependencyInjection
{
    internal class DependencyInjectedPayrollProcessor : IPayrollProcessor
    {
        private readonly IPaymentProcessorFactory _paymentProcessorFactory;

        public DependencyInjectedPayrollProcessor(IPaymentProcessorFactory paymentProcessorFactory)
        {
            _paymentProcessorFactory = paymentProcessorFactory;
        }
        
        public void PayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                _paymentProcessorFactory.GetPaymentProcessor(employee.PaymentMethod).PayEmployee(employee);
            }
        }
    }
}