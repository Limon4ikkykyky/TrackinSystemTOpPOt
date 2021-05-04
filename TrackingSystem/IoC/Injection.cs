using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.BLL.Services;

namespace IoC
{
    public class Injection : NinjectModule
    {
        public override void Load()
        {
            Bind<IServiceCreator>().To<ServiceCreator>();
            Bind<IUserService>().To<UserService>();
            Bind<ITasksService>().To<TasksService>();

        }
    }
}
