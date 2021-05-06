using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.DAL.EF;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Interfaces;

namespace TrackingSystem.BLL.Services
{
    public class CoursesService : ICoursesService
    {

        private readonly IUnitOfWork db;
        private readonly IMapper mapp;
        public CoursesService(EFUnitOfWork uow,IMapper mapper)
        {
            db = uow;
            mapp = mapper;

        }
        public async Task UpdateCourses(CoursesDTO courses)
        {
            
            Courses course = mapp.Map<CoursesDTO, Courses>(courses);
            db.Cours.Update(course);
            db.SaveAsync();
        }
        public async Task<IEnumerable<CoursesDTO>> GetCourses()
        {
           
            var courses = mapp.Map<IEnumerable<Courses>, IEnumerable<CoursesDTO>>(db.Cours.GetAll());
            return courses;
        }

        public async Task DeleteCourses(int id)
        {
            db.Cours.Delete(id);
        }

        public async Task Add(CoursesDTO coursesDTO)
        {
           
            Courses courses = mapp.Map<CoursesDTO, Courses>(coursesDTO);
            db.Cours.Create(courses);
            db.SaveAsync();



        }

        public async Task Dispose()
        {
            db.Dispose();
        }






    }
}

