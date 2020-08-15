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
    public class EfProductDal : EfEntityRepositoryDal<Product, CafeContext>, IProductDal
    {
        public List<Product> GetProductsByCatName(Expression<Func<Product, bool>> filter = null)
        {
            using (CafeContext db = new CafeContext())
            {
                if (filter == null)
                {
                    return db.Set<Product>().Include("Category").ToList();
                }
                else
                {
                    return db.Set<Product>().Include("Category").Where(filter).ToList();
                }
            }
        }

        public List<Product> GetProductsByProductName(Expression<Func<Product, bool>> filter = null)
        {
            using (CafeContext db = new CafeContext())
            {
                if (filter == null)
                {
                    return db.Set<Product>().Include("Category").ToList();
                }
                else
                {
                    return db.Set<Product>().Include("Category").Where(filter).ToList();
                }
            }
        }
    }
}
