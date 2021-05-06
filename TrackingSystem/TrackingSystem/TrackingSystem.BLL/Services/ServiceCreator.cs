using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.DAL.EF;
using TrackingSystem.DAL.Repositories;


namespace TrackingSystem.BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new EFUnitOfWork(connection));
        }
    }
}
