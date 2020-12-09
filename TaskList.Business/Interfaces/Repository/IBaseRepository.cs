using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoList.Business.Interfaces.Repository
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
    }
}
