using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DataLayer.Repository;
using ATM.DataLayer;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ATM.DataLayer.Services
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private ATM_DBEntities _db;
        private DbSet<TEntity> _dbset;

        public GenericRepository(ATM_DBEntities contex)
        {
            _db = contex;
            _dbset = _db.Set<TEntity>();
        }
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbset;
            if (where != null)
            {
                return query.Where(where).ToList();
            }
            return query.ToList();
        }
        public virtual TEntity Get(object ID)
        {
            return _dbset.Find(ID);
        }
        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                    _dbset.Attach(entity);
                }
                _dbset.Remove(entity);
        }
        public virtual void Delete(Object id)
        {
            var entity = Get(id);
            Delete(entity);
        }

    }

}
