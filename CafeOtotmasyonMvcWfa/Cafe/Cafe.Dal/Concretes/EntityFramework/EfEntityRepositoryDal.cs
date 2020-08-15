using Cafe.Dal.Abstracts;
using Cafe.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Dal.Concretes.EntityFramework
{
    public class EfEntityRepositoryDal<TEntity, TContext> : IEntityRepositoryDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext db = new TContext())
            {  
                var addEntity = db.Entry(entity);
                addEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var deleteEntity = db.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext db = new TContext())
            {
                if (filter == null)
                {
                    return db.Set<TEntity>().ToList();
                }
                else
                {
                    return db.Set<TEntity>().Where(filter).ToList();
                }
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var updateEntity = db.Entry(entity);
                updateEntity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
