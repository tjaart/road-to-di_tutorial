using Abstractions;
using Common;

namespace AbstractedCommon
{
    public class BankTransferPaymentProcessor : BankTransferProcessor, IPaymentProcessor
    {
        private readonly ILogger _logger;

        public BankTransferPaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }
        public bool PayEmployee(Employee employee)
        {
            var result = TransferMoney(employee.AccountNumber, employee.Salary);
            _logger.LogMessage("transfered money");
            return result.Success;
        }
    }
}