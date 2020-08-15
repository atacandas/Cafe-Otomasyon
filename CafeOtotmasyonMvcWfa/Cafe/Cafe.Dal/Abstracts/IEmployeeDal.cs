using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Abstracts
{
    public interface IEmployeeDal:IEntityRepositoryDal<Employee>
    {
        List<Employee> GetEmployeesByTitleName(Expression<Func<Employee, bool>> filter = null);
    }
}
