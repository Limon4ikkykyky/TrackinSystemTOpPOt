using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Interfaces;

namespace TrackingSystem.BLL.Services
{
    public class ManagerService : IManagerService
    {
        public IUnitOfWork db { get; set; }
        
        public async void DeleteUser(string id)
        {
            
            ApplicationUser user = await db.UserManager.FindByIdAsync(id);
            db.UserManager.DeleteAsync(user);
        }
      
    }
}
