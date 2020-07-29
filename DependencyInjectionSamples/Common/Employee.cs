namespace Common
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public PaymentMethod PaymentMethod
        {
            get;
            set;
        }

        public string AccountNumber { get; set; }
        public string MailAddress { get; set; }
    }
}