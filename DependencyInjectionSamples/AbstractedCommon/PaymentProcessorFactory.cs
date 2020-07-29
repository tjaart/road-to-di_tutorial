using System;
using Abstractions;
using Common;

namespace AbstractedCommon
{
    public class PaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor GetPaymentProcessor(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    return new CashPaymentProcessor();
                case PaymentMethod.Cheque:
                    return new ChequePaymentProcessor();
                // case PaymentMethod.BankTransfer:
                //     return new BankTransferPaymentProcessor();
                default:
                    throw new ArgumentOutOfRangeException(nameof(paymentMethod), paymentMethod, null);
            }
        }
    }
}