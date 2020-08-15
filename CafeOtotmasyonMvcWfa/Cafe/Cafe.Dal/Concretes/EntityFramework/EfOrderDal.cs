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
    public class EfOrderDal : EfEntityRepositoryDal<Order, CafeContext>, IOrderDal
    {
        public List<Order> GetOrdersByEmployeeName(Expression<Func<Order, bool>> filter = null)
        {
            using (CafeContext db = new CafeContext())
            {
                if (filter == null)
                {
                    return db.Set<Order>().Include("Employee").ToList();
                }
                else
                {
                    return db.Set<Order>().Include("Employee").Where(filter).ToList();
                }
            }
        }
    }
}
