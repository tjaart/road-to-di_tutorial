using System;
using System.Collections.Generic;
using AbstractedCommon;
using Abstractions;
using Common;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceLocator
{
    internal class ServiceLocatorPayrollProcessor : IPayrollProcessor
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorPayrollProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void PayEmployees(List<Employee> employees)
        {
            var paymentProcessorFactory  = _serviceProvider.GetService<IPaymentProcessorFactory>();
            foreach (var employee in employees)
            {
                paymentProcessorFactory
                    .GetPaymentProcessor(employee.PaymentMethod)
                    .PayEmployee(employee);
            }
        }
    }
}