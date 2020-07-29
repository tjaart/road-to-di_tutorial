using System.Collections.Generic;

namespace Common
{
    public class EmployeeDatabase : IEmployeeDatabase
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    AccountNumber = "1234",
                    Name = "Mark Knopfler",
                    Salary = 2000,
                    PaymentMethod = PaymentMethod.BankTransfer
                },
                new Employee
                {
                    Name = "Eric Clapton",
                    Salary = 3000,
                    MailAddress = "PO Box 5432, Somewhere",
                    PaymentMethod = PaymentMethod.Cheque
                },
                new Employee
                {
                    Name = "Jimmi Hendrix",
                    Salary = 4000,
                    PaymentMethod = PaymentMethod.Cash
                }
            };
        }
    }
}