using System;
using System.Collections.Generic;
using AbstractedCommon;
using Abstractions;
using Common;

namespace InversionOfControl
{
    internal class PayrollProcessorInverted
    {
        private readonly PaymentProcessorFactory _paymentProcessorFactory;

        public PayrollProcessorInverted(PaymentProcessorFactory paymentProcessorFactory)
        {
            _paymentProcessorFactory = paymentProcessorFactory;
        }
        
        public void PayEmployees(List<Employee> employees)
        {
            var logger = new Logger();
            
            foreach (var employee in employees)
            {
                _paymentProcessorFactory
                    .GetPaymentProcessor(employee.PaymentMethod)
                    .PayEmployee(employee);
            }
        }
    }

    public class Logger : ILogger
    {
        public void LogMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}