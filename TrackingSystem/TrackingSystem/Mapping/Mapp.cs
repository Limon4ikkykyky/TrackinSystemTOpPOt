using AutoMapper;
using TrackingSystem.BLL.DTO;
using TrackingSystem.DAL.Entities;

namespace TrackingSystem.BLL
{
  public  class UserMapping :Profile
    {
        public UserMapping()
        {
            CreateMap<ClientProfile, UserDTO>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
            CreateMap<ApplicationRole, UserDTO>().ReverseMap();
            CreateMap<Tasks, TasksDTO>().ReverseMap();
            CreateMap<Courses, CoursesDTO>().ReverseMap();
        }
    }
}
