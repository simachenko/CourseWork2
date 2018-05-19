using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
namespace DataAccessLayer.TimetableDataStorage.Repos
{
     class DayRepository : IRepository<Day>
     {
        private DbTimetable dbTables;

        public DayRepository(DbTimetable dbTables)
        {
            this.dbTables = dbTables;
        }

        public void Create(Day item)
        {
            dbTables.days.Add(item);
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
            dbTables.days.Remove(item);
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
    }
}
