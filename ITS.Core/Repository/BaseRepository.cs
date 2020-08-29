using ITS.Core.Base;
using ITS.Core.DBEntity;
using ITS.Core.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ITS.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class// BaseEntity
    {
        protected SKSTestDBContext _context;
        public BaseRepository(SKSTestDBContext context)
        {
            _context = context;
        }

        public T GetById(long id)
        {
            return _context.Set<T>().Find(id);
        }
        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChangesAsync();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAllByFilter(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }
    }
}
