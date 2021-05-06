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


    public class CoursesRepositories : IRepository<Courses>

    {
        private ApplicationContext db;
        public CoursesRepositories(ApplicationContext db) { this.db = db; }
        public IEnumerable<Courses> GetAll()
        {
            return db.Cours;
        }
        public Courses Get(string id)
        {
            return db.Cours.Find(id);
        }
        public IEnumerable<Courses> Find(Func<Courses, Boolean> predicate)
        {
            return db.Cours.Where(predicate).ToList();
        }
        public void Create(Courses course)
        {
            db.Cours.Add(course);
        }
        public void Delete(int id)
        {
            Courses course = db.Cours.Find(id);
            if (course != null)
                db.Cours.Remove(course);
        }
        public void Update(Courses course)
        {
            db.Entry(course).State = EntityState.Modified;
        }
    }
}



