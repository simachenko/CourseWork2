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
     class LessonRepository : IRepository<Lesson>
    {
        [Inject]
        private DbTimetable DbTables; /*= NinjectKernel.NinjectContext.Get<DbTimetable>();*/

        [Inject]
        public LessonRepository(DbTimetable DbTables)
        {
            this.DbTables = DbTables;
            //this.DbTables = NinjectKernel.NinjectContext.Get<DbTimetable>();
        }
        public void Create(Lesson item)
        {
            DbTables.Lessons.Add(item);
        }

        public Lesson Get(int Id)
        {
            return DbTables.Lessons.Find(Id);
        }

        public ICollection<Lesson> Get()
        {
            return DbTables.Lessons.ToList();
        }

        public ICollection<Lesson> Get(Func<Lesson, bool> predicate)
        {
            return DbTables.Lessons.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Lesson item)
        {
            DbTables.Lessons.Remove(item);
        }

        public void Remove(int Id)
        {
            Lesson ent = DbTables.Lessons.Find(Id);
            if (ent != null)
            {
                DbTables.Lessons.Remove(ent);
            }
        }

        public void Update(Lesson item)
        {
            DbTables.Entry(item).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            this.DbTables.SaveChanges();
        }
        public void Dispose()
        {
            DbTables.Dispose();
        }
    }
}
