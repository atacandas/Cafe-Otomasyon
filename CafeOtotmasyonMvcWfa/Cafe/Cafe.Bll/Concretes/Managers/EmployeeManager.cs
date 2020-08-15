using Cafe.Bll.Abstracts;
using Cafe.Dal.Abstracts;
using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Bll.Concretes.Managers
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        private static EmployeeManager _employeeManager;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public static EmployeeManager CreateSingleton(IEmployeeDal employeeDal)
        {
            if (_employeeManager == null)
            {
                _employeeManager = new EmployeeManager(employeeDal);
            }

            return _employeeManager;
        }


        public void AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeDal.Add(employee);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public void DeleteEmployee(int id)
        {
            if (id > 1)
            {
                _employeeDal.Delete(new Employee { EmployeeID = id });
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Employee GetEmployee(int id)
        {
            return _employeeDal.Get(emp => emp.EmployeeID == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDal.GetEmployeesByTitleName();
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeDal.Update(employee);
            }
            else
            {
                throw new Exception("Hata oldu");
            }
        }

        public Employee GetEmployee(string username, string password)
        {
            return _employeeDal.Get(emp => emp.UserName == username && emp.Password == password);
        }

        public Employee GetEmployee(string username)
        {
            return _employeeDal.Get(emp => emp.UserName == username);
        }
    }
}
