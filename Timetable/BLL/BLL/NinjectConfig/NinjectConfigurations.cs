using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using DataAccessLayer.TimetableDataStorage;
using DataAccessLayer.UsersDataStorage;

namespace BLL.NinjectConfig
{
    class NinjectConfigurations : NinjectModule
    {
        public override void Load()
        {
            Bind<UoWTimetable>().To<UoWTimetable>();
            Bind<UoWUsers>().To<UoWUsers>();
            Bind<Core.CoreTimetable>().To<Core.CoreTimetable>().InSingletonScope();
            Bind<Core.CoreUser>().To<Core.CoreUser>();
        }
    }
}
