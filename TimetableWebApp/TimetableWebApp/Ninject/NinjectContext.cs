using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
namespace TimetableWebApp.Ninject
{
    public static class NinjectContext
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