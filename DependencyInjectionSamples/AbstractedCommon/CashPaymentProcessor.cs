using Abstractions;
using Common;

namespace AbstractedCommon
{
    public class CashPaymentProcessor : CashHandler, IPaymentProcessor
    {
        public bool PayEmployee(Employee employee)
        {
            return DeliverCashEnvelope(employee.Name, employee.Salary);
        }
    }
}