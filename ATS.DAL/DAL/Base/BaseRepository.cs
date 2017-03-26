using System.Collections.Generic;
using System.Linq;
using test1.Interfaces.DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using System;

namespace ATS.DAL.DAL
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected DbContext _db;

        public BaseRepository(DbContext db)
        {
            _db = db;
        }

        public DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }

        public bool Add(T entity)
        {
            Table.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            Table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public ICollection<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }
    }
}