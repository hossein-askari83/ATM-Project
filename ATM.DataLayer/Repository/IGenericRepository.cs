using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ATM.DataLayer.Repository
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null);

        void Insert(TEntity entity);

        TEntity Get(object ID);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
