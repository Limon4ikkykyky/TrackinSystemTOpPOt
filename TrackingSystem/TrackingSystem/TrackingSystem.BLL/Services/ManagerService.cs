using AutoMapper;
using Microsoft.AspNet.Identity;
using System.Linq;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Interfaces;
using TrackingSystem.DAL.Repositories;

namespace TrackingSystem.BLL.Services
{
    public class ManagerService : IManagerService
    {
        public IUnitOfWork db { get; set; }


        public void AddUserforTasks(string taskId, string userId)
        {
            var MyCurrentTask = db.Task.GetAll().FirstOrDefault(t => t.TasksID == taskId);
                MyCurrentTask.Students.Add(db.UserManager.FindById(userId));
                db.SaveAsync();
        }

        public async void DeleteUser(string id)
        {
            
            ApplicationUser user = await db.UserManager.FindByIdAsync(id);
            db.UserManager.DeleteAsync(user);
        }
      
    }
}
