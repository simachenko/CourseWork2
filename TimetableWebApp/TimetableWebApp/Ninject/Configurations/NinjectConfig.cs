using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject;
using BLL.Interfaces;
using BLL.Users;
namespace TimetableWebApp.Ninject.Configurations
{
    public class NinjectConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdmin>().To<UserImplementation>();
            Bind<IEditor>().To<UserImplementation>();
            Bind<IManager>().To<UserImplementation>();
            Bind<ITeacher>().To<UserImplementation>();
            Bind<IStudent>().To<UserImplementation>();

        }
    }
}