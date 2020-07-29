using System;
using Abstractions;
using Common;

namespace AbstractedCommon
{
    public class DIPaymentProcessingFactory : IPaymentProcessorFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DIPaymentProcessingFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPaymentProcessor GetPaymentProcessor(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    return (IPaymentProcessor) _serviceProvider.GetService(typeof(CashPaymentProcessor));
                case PaymentMethod.Cheque:
                    return (IPaymentProcessor) _serviceProvider.GetService(typeof(ChequePaymentProcessor));
                case PaymentMethod.BankTransfer:
                    return (IPaymentProcessor) _serviceProvider.GetService(typeof(BankTransferPaymentProcessor));
                default:
                    throw new ArgumentOutOfRangeException(nameof(paymentMethod), paymentMethod, null);
            }
        }
    }
}