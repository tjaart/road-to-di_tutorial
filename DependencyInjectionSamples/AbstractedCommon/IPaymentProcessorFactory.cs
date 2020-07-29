using Abstractions;
using Common;

namespace AbstractedCommon
{
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor GetPaymentProcessor(PaymentMethod paymentMethod);
    }
}