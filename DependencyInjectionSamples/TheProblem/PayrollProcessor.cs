using System;
using System.Collections.Generic;
using Common;

namespace TheProblem
{
    public class PayrollProcessor
    {
        private readonly BankTransferProcessor _bankTransferProcessor;
        private readonly CashHandler _cashHandler;
        private readonly AccountingManager _accountingManager;

        public PayrollProcessor()
        {
            _bankTransferProcessor = new BankTransferProcessor();
            _cashHandler = new CashHandler();
            _accountingManager = new AccountingManager();
        }
        
        public void PayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                switch (employee.PaymentMethod)
                {
                    case PaymentMethod.BankTransfer:
                        _bankTransferProcessor.TransferMoney(employee.AccountNumber, employee.Salary);
                        break;
                    case PaymentMethod.Cash:
                        _cashHandler.DeliverCashEnvelope(employee.Name, employee.Salary);
                        break;
                    case PaymentMethod.Cheque:
                        _accountingManager.IssueAndMailCheque(employee.MailAddress, employee.Salary);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}