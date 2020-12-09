using Microsoft.EntityFrameworkCore;
using System.Linq;
using TodoList.Business.Interfaces.Repository;
using TodoList.Data.Context;

namespace TodoList.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        protected readonly AppDbContext context;
        protected readonly DbSet<TEntity> dbSet;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public virtual TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Add(TEntity obj)
        {
            dbSet.Add(obj);
            context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            dbSet.Update(obj);
            context.SaveChanges();
        }

        public virtual void Delete(TEntity obj)
        {
            dbSet.Remove(obj);
            context.SaveChanges();
        }
    }
}
