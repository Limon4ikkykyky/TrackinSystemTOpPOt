using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;

namespace TrackingSystem.BLL.Interfaces
{
    public interface IManagerService
    {
        void DeleteUser(string id);

        void AddUserforTasks(string taskId, string userId);


    }
}