using DataAccessLayer.TimetableDataStorage.Repos;
using Entities;
using Entities.TimetableEntity;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.TimetableDataStorage.NIjectConfig
{
    class NinjectConfigTest : NinjectModule
    {
        public override void Load()
        {
            Bind<DbTimetable>().ToSelf().InSingletonScope().WithConstructorArgument("DbTimetableTest");
            Bind<IRepository<Lesson>>().To<LessonRepository>();
            //Bind<IRepository<Day>>().To<DayRepository>();
            //Bind<IRepository<Week>>().To<WeekRepository>();
            Bind<IRepository<Group>>().To<GroupRepository>();

        }
    }
}
