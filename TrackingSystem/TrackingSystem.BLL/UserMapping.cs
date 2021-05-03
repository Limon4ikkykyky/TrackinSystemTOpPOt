using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
