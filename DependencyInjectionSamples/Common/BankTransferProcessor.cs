using System;

namespace Common
{
    public class BankTransferProcessor
    {
        public BankTransferResult TransferMoney(string employeeAccountNumber, in decimal employeeSalary)
        {
            // initiate bank API call
            Console.WriteLine($"Transferring money to employee account {employeeAccountNumber} : {employeeSalary}");
            return new BankTransferResult
            {
                Success = true
            };
        }
    }
}