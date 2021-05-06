using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Identity;
using TrackingSystem.DAL.Interfaces;
using TrackingSystem.DAL.Repositories;

namespace TrackingSystem.DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork

    {
        private ApplicationContext db;
        private TasksRepositories tasksRepositories;
        private CoursesRepositories coursesRepositories;
        //private IGenericRepository<Tasks> task;
        //private IGenericRepository<Courses> courses;
        private ApplicationUserManager userManager;
        private ApplicationRoleManager roleManager;
        private IClientManager clientManager;

        public EFUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                if (userManager == null)
                    userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
                return userManager;
            }
        }
        public ApplicationRoleManager RoleManager
        {
            get
            {
                if (roleManager == null)
                    roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
                return roleManager;
            }
        }
        public IClientManager ClientManager
        {
            get
            {
                if (clientManager == null)
                    clientManager = new ClientManager(db);
                return clientManager;
            }
        }
        public IRepository<Tasks> Task
        {
            get
            {
                if (tasksRepositories == null)
                    tasksRepositories = new TasksRepositories(db);
                return tasksRepositories;
            }

        }
        public IRepository<Courses> Cours
        {
            get
            {
                if (coursesRepositories == null)
                    coursesRepositories = new CoursesRepositories(db);
                return coursesRepositories;
            }

        }
        //public IGenericRepository<Tasks> Task
        //{
        //    get
        //    {
        //        if (task == null)
        //            task = new EFGenericRepository<Tasks>(db);
        //        return task;
        //    }
        //}
        //public IGenericRepository<Courses> Course
        //{
        //    get
        //    {
        //        if (courses == null)
        //            courses = new EFGenericRepository<Courses>(db);
        //        return courses;
        //    }
        //}
        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
