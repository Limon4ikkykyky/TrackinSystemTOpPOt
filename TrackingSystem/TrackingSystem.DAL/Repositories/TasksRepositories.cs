using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.EF;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Interfaces;

namespace TrackingSystem.DAL.Repositories
{
    public class TasksRepositories : IRepository<Tasks>
    
    {
        private ApplicationContext db;
        public TasksRepositories(ApplicationContext db) { this.db = db; }
        public IEnumerable<Tasks> GetAll()
        {
            return db.Task;
        }
        public Tasks Get(int id)
        {
            return db.Task.Find(id);
        }
        public IEnumerable<Tasks> Find(Func<Tasks, Boolean> predicate)
        {
            return db.Task.Where(predicate).ToList();
        }
        public void Create(Tasks task)
        {
            db.Task.Add(task);
        }
        public void Delete(int id)
        {
            Tasks task = db.Task.Find(id);
            if (task != null)
                db.Task.Remove(task);
        }
        public void Update(Tasks task)
        {
            db.Entry(task).State = EntityState.Modified;
        }
    }
}

