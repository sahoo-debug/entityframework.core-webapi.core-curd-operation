using ITS.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ITS.Core.IRepository
{
    public interface IBaseRepository<T> where T : class //BaseEntity
    {
        T GetById(long id);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByFilter(Expression<Func<T, bool>> predicate);
    }
}
