using _01_DataAccessLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        TaskManagementContext _context;

        internal BaseRepository(TaskManagementContext context)
        {
            _context = context;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            _context.EntityleriBosaCikar();
            return _context.Set<TEntity>().ToList();
        }

        public void Add(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public void Remove(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
