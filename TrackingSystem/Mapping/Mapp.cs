using AutoMapper;
using TrackingSystem.BLL.DTO;
using TrackingSystem.DAL.Entities;

namespace TrackingSystem.BLL
{
  public  class UserMapping :Profile
    {
        public UserMapping()
        {
            CreateMap<ClientProfile, UserDTO>();
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<ApplicationRole, UserDTO>();
        }
    }
}
