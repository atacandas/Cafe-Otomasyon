using Cafe.Dal.Abstracts;
using Cafe.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Concretes.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryDal<Category,CafeContext>,ICategoryDal
    {
    }
}
