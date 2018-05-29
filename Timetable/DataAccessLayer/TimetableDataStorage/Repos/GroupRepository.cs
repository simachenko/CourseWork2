using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using Entities.TimetableEntity;
using Ninject;
namespace DataAccessLayer.TimetableDataStorage.Repos
{
     class GroupRepository : IRepository<Group>
      {
        [Inject]
        private DbTimetable dbTables; /*= NinjectKernel.NinjectContext.Get<DbTimetable>();*/
        [Inject]
        public GroupRepository(DbTimetable dbTables)
        {
            this.dbTables = dbTables;
            //this.dbTables = NinjectKernel.NinjectContext.Get<DbTimetable>();
        }

        public void Create(Group item)
        {
            dbTables.Groups.Add(item);
        }

        public Group Get(int Id)
        {
            return dbTables.Groups.Find(Id);
        }

        public ICollection<Group> Get()
        {
            return dbTables.Groups.AsNoTracking().ToList();
        }

        public ICollection<Group> Get(Func<Group, bool> predicate)
        {
            return dbTables.Groups.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Group item)
        {
            dbTables.Groups.Remove(item);
        }

        public void Remove(int Id)
        {
            Group group = Get(Id);
            if (group != null)
            {
                Remove(group);
            }
        }

        public void Update(Group item)
        {
            dbTables.Entry(item).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            dbTables.SaveChanges();
        }
        public void Dispose()
        {
            dbTables.Dispose();
        }
    }
}
