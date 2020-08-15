using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Abstracts
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        List<Product> GetProductsByCatName(Expression<Func<Product, bool>> filter = null);
        List<Product> GetProductsByProductName(Expression<Func<Product, bool>> filter = null);
    }
}
