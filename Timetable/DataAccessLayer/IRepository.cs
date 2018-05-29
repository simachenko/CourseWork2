using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<TEntity> 
        where TEntity : Entities.Entity
    {
        TEntity Get(int Id);
        void Create(TEntity item);
        ICollection<TEntity> Get();
        ICollection<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Remove(int Id);
        void Update(TEntity item);
        void SaveChanges();
        void Dispose();       
    }
}
