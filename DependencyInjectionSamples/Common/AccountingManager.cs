using System;

namespace Common
{
    public class AccountingManager
    {
        public void IssueAndMailCheque(string employeeMailAddress, in decimal employeeSalary)
        {
            // send a cheque mail request to accounting department
            Console.WriteLine($"A cheque will be issued for {employeeSalary} and posted to the following mail address: {employeeMailAddress}");
        }
    }
}