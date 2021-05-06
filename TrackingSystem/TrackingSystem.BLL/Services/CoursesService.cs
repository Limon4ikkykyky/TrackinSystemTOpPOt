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

        public IUnitOfWork db { get; set; }
        public CoursesService(EFUnitOfWork uow)
        {
            db = uow;
        }
        public void UpdateCourses(CoursesDTO courses)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<CoursesDTO, Courses>()).CreateMapper();
            Courses course = mapper.Map<CoursesDTO, Courses>(courses);
            db.Cours.Update(course);
            db.SaveAsync();
        }
        public IEnumerable<CoursesDTO> GetCourses()
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<Courses, CoursesDTO>()).CreateMapper();
            var courses = mapper.Map<IEnumerable<Courses>, IEnumerable<CoursesDTO>>(db.Cours.GetAll());
            return courses;
        }

        public void DeleteCourses(int id)
        {
            db.Cours.Delete(id);
        }

        public void Add(CoursesDTO coursesDTO)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<CoursesDTO, Courses>()).CreateMapper();
            Courses courses = mapper.Map<CoursesDTO, Courses>(coursesDTO);
            db.Cours.Create(courses);
            db.SaveAsync();



        }

        public void Dispose()
        {
            db.Dispose();
        }






    }
}

