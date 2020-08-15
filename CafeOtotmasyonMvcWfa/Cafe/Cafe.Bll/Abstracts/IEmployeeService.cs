using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Abstracts
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(string username, string password);
        Employee GetEmployee(int id);
        Employee GetEmployee(string username);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
