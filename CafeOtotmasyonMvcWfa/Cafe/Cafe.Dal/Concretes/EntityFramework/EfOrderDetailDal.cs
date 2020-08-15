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
    public class EfOrderDetailDal : EfEntityRepositoryDal<OrderDetail, CafeContext>, IOrderDetailDal
    {
        public List<OrderDetail> GetOrderDetailWithProductName(Expression<Func<OrderDetail, bool>> filter = null)
        {
            using (CafeContext db = new CafeContext())
            {
                if (filter == null)
                {
                    return db.Set<OrderDetail>().Include("Product").ToList();
                }
                else
                {
                    return db.Set<OrderDetail>().Include("Product").Where(filter).ToList();
                }
            }
        }
    }
}
