using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.UsersEntity;
using Entities;
namespace DataAccessLayer.UsersDataStorage.Repository
{
    class UserRepository : IRepository<User>
    {
        private DbUsers dbUsers;
        public UserRepository(DbUsers dbUsers)
        {
            this.dbUsers = dbUsers;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }

        public void Create(User item)
        {
            dbUsers.users.Add(item);
        }

        public User Get(int Id)
        {
            return dbUsers.users.Find(Id);
        }

        public ICollection<User> Get()
        {
            return dbUsers.users.ToList();
        }

        public ICollection<User> Get(Func<User, bool> predicate)
        {
            return dbUsers.users.Where(predicate).ToList();
        }

        public void Remove(User item)
        {
            dbUsers.users.Remove(item);
        }

        public void Remove(int Id)
        {
            User item = Get(Id);
            if (item != null)
            {
                Remove(item);
            }
        }

        public void Update(User item)
        {
            dbUsers.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

        public void SaveChanges()
        {
            dbUsers.SaveChanges();
        }
        public void Dispose()
        {
            dbUsers.Dispose();
        }
    }
}
