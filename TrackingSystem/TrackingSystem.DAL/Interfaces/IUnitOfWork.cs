using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Identity;
using TrackingSystem.DAL.Repositories;

namespace TrackingSystem.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }
        //IGenericRepository<Tasks> Task { get; }
        IRepository<Courses> Cours { get; }
        IRepository<Tasks> Task { get; }
        Task SaveAsync();
    }
}
