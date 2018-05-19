using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
namespace DataAccessLayer.TimetableDataStorage.Repos
{
     class LessonRepository : IRepository<Lesson>
    {
        private DbTimetable DbTables;

        public LessonRepository(DbTimetable DbTables)
        {
            this.DbTables = DbTables;
        }

        public void Create(Lesson item)
        {
            DbTables.lessons.Add(item);
        }

        public Lesson Get(int Id)
        {
            return DbTables.lessons.Find(Id);
        }

        public IEnumerable<Lesson> Get()
        {
            return DbTables.lessons.ToList();
        }

        public IEnumerable<Lesson> Get(Func<Lesson, bool> predicate)
        {
            return DbTables.lessons.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Lesson item)
        {
            DbTables.lessons.Remove(item);
        }

        public void Remove(int Id)
        {
            Lesson ent = DbTables.lessons.Find(Id);
            if (ent != null)
            {
                DbTables.lessons.Remove(ent);
            }
        }

        public void Update(Lesson item)
        {
            DbTables.Entry(item).State = EntityState.Modified;
        }
        
    }
}
