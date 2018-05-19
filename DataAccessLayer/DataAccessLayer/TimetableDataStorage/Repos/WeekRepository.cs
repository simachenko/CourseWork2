using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
namespace DataAccessLayer.TimetableDataStorage.Repos
{
     class WeekRepository : IRepository<Week>
    {
        private DbTimetable dbTables;

        public WeekRepository(DbTimetable dbTables)
        {
            this.dbTables = dbTables;
        }

        public void Create(Week item)
        {
            dbTables.weeks.Add(item);
        }

        public Week Get(int Id)
        {
            return dbTables.weeks.Find(Id);
        }

        public IEnumerable<Week> Get()
        {
            return dbTables.weeks.AsNoTracking().ToList();
        }

        public IEnumerable<Week> Get(Func<Week, bool> predicate)
        {
            return dbTables.weeks.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Week item)
        {
            dbTables.weeks.Remove(item);
        }

        public void Remove(int Id)
        {
            Week week = Get(Id);
            if (week != null)
            {
                dbTables.weeks.Remove(week);
            }
        }

        public void Update(Week item)
        {
            dbTables.Entry(item).State = EntityState.Modified;
        }
    }
}
