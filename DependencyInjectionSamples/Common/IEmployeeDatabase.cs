using System.Collections.Generic;

namespace Common
{
    public interface IEmployeeDatabase
    {
        List<Employee> GetEmployees();
    }
}