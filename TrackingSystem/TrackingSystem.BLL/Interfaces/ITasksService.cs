using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;

namespace TrackingSystem.BLL.Interfaces
{
    public interface ITasksService
    {
        Task UpdateTasks(TasksDTO task);
       Task <IEnumerable<TasksDTO>> GetTasks();
  
        Task Add(TasksDTO tasksDTO);
        
        
        Task DeleteTasks(int id);
       
        void Dispose();
    }
}
