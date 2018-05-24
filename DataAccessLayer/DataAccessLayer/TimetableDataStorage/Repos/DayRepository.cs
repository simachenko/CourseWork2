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
     class DayRepository : IRepository<Day>
     {
        [Inject]
        private DbTimetable dbTables = NinjectKernel.NinjectContext.Get<DbTimetable>();
        [Inject]
        public DayRepository(DbTimetable dbTables)
        {
            //this.dbTables = NinjectKernel.NinjectContext.Get<DbTimetable>();
        }

        public void Create(Day item)
        {
            dbTables.Entry(item).State = EntityState.Added;
        }

        public Day Get(int Id)
        {
            return dbTables.days.Find(Id);
        }

        public IEnumerable<Day> Get()
        {
            return dbTables.days.ToList();
        }

        public IEnumerable<Day> Get(Func<Day, bool> predicate)
        {
            return dbTables.days.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Day item)
        {
            dbTables.Entry(item).State = EntityState.Deleted;
        }

        public void Remove(int Id)
        {
            Day day = Get(Id);
            if (day != null)
            {
                dbTables.days.Remove(day);
            }
        }

        public void Update(Day item)
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
