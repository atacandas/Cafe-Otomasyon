using Cafe.Dal.Abstracts;
using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Concretes.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryDal<Employee, CafeContext>, IEmployeeDal
    {
        public List<Employee> GetEmployeesByTitleName(Expression<Func<Employee, bool>> filter = null)
        {
            using (CafeContext db = new CafeContext())
            {
                if (filter == null)
                {
                    return db.Set<Employee>().Include("Title").ToList();
                }
                else
                {
                    return db.Set<Employee>().Include("Title").Where(filter).ToList();
                }
            }
        }
    }
}
