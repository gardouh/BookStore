using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repo
{
   public interface IBookstoreRepository<TEntity>
    {

        IList<TEntity> List();

        TEntity Find(int id);
        void  Add(TEntity entity);
        void Delete(int id);
        void Update(int id, TEntity entity);
    }
}
