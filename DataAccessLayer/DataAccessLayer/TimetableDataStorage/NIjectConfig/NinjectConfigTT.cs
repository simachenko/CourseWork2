using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using System.Data.Entity;
using DataAccessLayer.TimetableDataStorage.Repos;
using Entities;

namespace DataAccessLayer.TimetableDataStorage.NIjectConfig
{
    class NinjectConfigTT : NinjectModule
    {
        public override void Load()
        {
            Bind<DbTimetable>().ToSelf().WithConstructorArgument("Timetable");
            Bind<IRepository<Lesson>>().To<LessonRepository>();
            Bind<IRepository<Day>>().To<DayRepository>();
            Bind<IRepository<Week>>().To<WeekRepository>();
            Bind<IRepository<Group>>().To<GroupRepository>();
        }
    }
}
