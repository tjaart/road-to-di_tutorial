using System.Collections.Generic;
using Common;

namespace Abstractions
{
    public interface IPayrollProcessor
    {
        void PayEmployees(List<Employee> employees);
    }
}