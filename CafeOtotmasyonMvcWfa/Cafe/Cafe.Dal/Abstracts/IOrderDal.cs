using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Abstracts
{
    public interface IOrderDal: IEntityRepositoryDal<Order>
    {
        List<Order> GetOrdersByEmployeeName(Expression<Func<Order, bool>> filter = null);
    }
}
