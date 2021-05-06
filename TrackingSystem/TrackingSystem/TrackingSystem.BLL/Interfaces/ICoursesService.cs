using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;

namespace TrackingSystem.BLL.Interfaces
{
    public interface ICoursesService
    {
        void UpdateCourses(CoursesDTO courses);
        IEnumerable<CoursesDTO> GetCourses();

        void Add(CoursesDTO coursesDTO);


        void DeleteCourses(int id);

        void Dispose();
    }
}
