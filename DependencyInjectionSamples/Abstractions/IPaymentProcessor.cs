using Common;

namespace Abstractions
{
    public interface IPaymentProcessor
    {
        bool PayEmployee(Employee employee);
    }
}