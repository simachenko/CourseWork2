//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Entities;
//using System.Data.Entity;
//using Entities.TimetableEntity;
//using Ninject;

//namespace DataAccessLayer.TimetableDataStorage.Repos
//{
//     class WeekRepository : IRepository<Week>
//     {
//        [Inject]
//        private DbTimetable dbTables; /*= NinjectKernel.NinjectContext.Get<DbTimetable>();*/
//        [Inject]
//        public WeekRepository(DbTimetable dbTables)
//        {
//            this.dbTables = dbTables;
//            //this.dbTables = NinjectKernel.NinjectContext.Get<DbTimetable>();
//        }

//        public void Create(Week item)
//        {
//            dbTables.Weeks.Add(item);
//        }

//        public Week Get(int Id)
//        {
//            return dbTables.Weeks.Find(Id);
//        }

//        public IEnumerable<Week> Get()
//        {
//            return dbTables.Weeks.AsNoTracking().ToList();
//        }

//        public IEnumerable<Week> Get(Func<Week, bool> predicate)
//        {
//            return dbTables.Weeks.AsNoTracking().Where(predicate).ToList();
//        }

//        public void Remove(Week item)
//        {
//            dbTables.Weeks.Remove(item);
//        }

//        public void Remove(int Id)
//        {
//            Week week = Get(Id);
//            if (week != null)
//            {
//                dbTables.Weeks.Remove(week);
//            }
//        }

//        public void Update(Week item)
//        {
//            dbTables.Entry(item).State = EntityState.Modified;
//        }

//        public void SaveChanges()
//        {
//            dbTables.SaveChanges();
//        }
//        public void Dispose()
//        {
//            dbTables.Dispose();
//        }
//    }
//}
