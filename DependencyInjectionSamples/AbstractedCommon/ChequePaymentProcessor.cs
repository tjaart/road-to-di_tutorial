using System;
using Abstractions;
using Common;

namespace AbstractedCommon
{
    public class ChequePaymentProcessor : AccountingManager, IPaymentProcessor
    {
        public bool PayEmployee(Employee employee)
        {
            try
            {
                IssueAndMailCheque(employee.MailAddress, employee.Salary);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}