using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using DataAccessLayer.UsersDataStorage;
using Entities;
using Entities.UsersEntity;
namespace DataAccessLayer.UsersDataStorage.NInjectConfigs
{
    class NInjectCofigUser : NinjectModule
    {
        public override void Load()
        {
            Bind<DbUsers>().ToSelf().InSingletonScope().WithConstructorArgument("Users");
            Bind<IRepository<User>>().To<UsersDataStorage.Repository.UserRepository>();
        }
    }
}
