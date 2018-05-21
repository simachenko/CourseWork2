using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.UsersEntity;
using Entities;
namespace DataAccessLayer.UsersDataStorage.Repository
{
    class TeacherRepository : IRepository<Teacher>
    {
        private DbUsers dbUsers;

        public TeacherRepository(DbUsers dbUsers)
        {
            this.dbUsers = dbUsers;
        }

        public void Create(Teacher item)
        {
            dbUsers.Teachers.Add(item);
        }

        public Teacher Get(int Id)
        {
            return dbUsers.Teachers.Find(Id);
        }

        public IEnumerable<Teacher> Get()
        {
            return dbUsers.Teachers.ToList();
        }

        public IEnumerable<Teacher> Get(Func<Teacher, bool> predicate)
        {
            return dbUsers.Teachers.Where(predicate).ToList();
        }

        public void Remove(Teacher item)
        {
            dbUsers.Teachers.Remove(item);
        }

        public void Remove(int Id)
        {
            Teacher item = Get(Id);
            if (item != null)
            {
                Remove(item);
            }
        }

        public void Update(Teacher item)
        {
            dbUsers.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
