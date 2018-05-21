using DataAccessLayer.TimetableDataStorage.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using Entities.UsersEntity;

namespace DataAccessLayer.UsersDataStorage.Repos
{
    class UserRepository : IRepository<User>
    {
        void IRepository<User>.Create(User item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IRepository<User>.Get()
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IRepository<User>.Get(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Remove(int Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Remove(User item)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
