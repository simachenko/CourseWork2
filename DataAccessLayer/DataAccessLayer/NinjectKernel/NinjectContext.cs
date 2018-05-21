using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject;
using DataAccessLayer.TimetableDataStorage.NIjectConfig;

namespace DataAccessLayer.NinjectKernel
{
    static class NinjectContext
    {
        public static IKernel kernel;
        public static void SeUp(params INinjectModule[] configs)
        {
            kernel = new StandardKernel(configs);
            
        }
        public static T Get<T>()
        {
            return kernel.Get<T>();
        }
        

    }
}
