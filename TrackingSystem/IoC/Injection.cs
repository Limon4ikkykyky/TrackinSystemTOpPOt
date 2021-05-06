using AutoMapper;
using Ninject.Modules;
using TrackingSystem.BLL;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.BLL.Services;

namespace IoC
{
    public class Injection : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IServiceCreator>().To<ServiceCreator>();
            Bind<IUserService>().To<UserService>();
            Bind<ITasksService>().To<TasksService>();
            Bind<IManagerService>().To<ManagerService>();
            Bind<IMapper>().ToMethod(ctx =>
            {
                return new Mapper(new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<Mapp>();

                }));
            });

        }
     
    }
}
