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
        Task UpdateCourses(CoursesDTO courses);
        Task<IEnumerable<CoursesDTO>> GetCourses();

        Task Add(CoursesDTO coursesDTO);


        Task DeleteCourses(int id);

        Task Dispose();
    }
}
